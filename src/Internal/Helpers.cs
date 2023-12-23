using System.Text.RegularExpressions;

namespace Cti.Stix.Internal
{
    internal static class Helpers
    {
        // ValidObjectType - This function will take in a STIX object type and return
        // true if the string represents an actual STIX object type. This is used for
        // determining if input from an outside source is actually a defined STIX object or
        // not.
        public static bool ValidObjectType(string t)
        {
            var validTypes = new HashSet<string>
            {
                "attack-pattern", "campaign", "course-of-action", "grouping", "identity", "indicator",
                "infrastructure", "intrusion-set", "language-content", "location", "malware", "malware-analysis",
                "marking-definition", "note", "observed-data", "opinion", "relationship", "report", "sighting",
                "threat-actor", "tool", "vulnerability"
            };

            return validTypes.Contains(t);
        }

        // IsUUIDValid - This function will take in a string and return true if the
        // string represents an actual UUID v4 or v5 value.
        public static bool IsUUIDValid(string uuid)
        {
            var regex = new Regex(@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[4-5][a-fA-F0-9]{3}-[8-9aAbB][a-fA-F0-9]{3}-[a-fA-F0-9]{12}$");
            return regex.IsMatch(uuid);
        }

        // GetCurrentSpecVersion - This function returns the current specification version
        // that this library is using.
        public static string GetCurrentSpecVersion()
        {
            return Constants.CurrentSTIXVersion;
        }

        // GetCurrentTime - This function takes in a value of either milli or micro and
        // returns the current time in RFC 3339 format
        public static string GetCurrentTime(string precision = "milli")
        {
            return precision switch
            {
                "milli" => DateTime.UtcNow.ToString(Constants.TimeRFC3339Milli),
                "micro" => DateTime.UtcNow.ToString(Constants.TimeRFC3339Micro),
                _ => DateTime.UtcNow.ToString(Constants.TimeRFC3339)
            };
        }

        // TimeToString - This function takes in a timestamp in either DateTime or string
        // format and returns a string version of the timestamp.
        public static string TimeToString(object t, string precision)
        {
            var format = precision switch
            {
                "milli" => Constants.TimeRFC3339Milli,
                "micro" => Constants.TimeRFC3339Micro,
                _ => Constants.TimeRFC3339
            };

            return t switch
            {
                DateTime time => time.ToUniversalTime().ToString(format),
                string str => str,
                _ => throw new ArgumentException("Invalid timestamp format")
            };
        }

        // IsTimestampValid - This function will take in a timestamp and check to see if
        // it is valid per the specification.
        public static bool IsTimestampValid(string t)
        {
            var regex = new Regex(@"^[12]\d{3}-[01]\d{1}-[0-3]\d{1}T[0-2]\d{1}:[0-5]\d{1}:[0-5]\d{1}(\.\d{0,6})?Z$");
            return regex.IsMatch(t);
        }

        // AddValuesToList - This function will add a single value, a comma-separated
        // list of values, or a list of values to a list.
        public static void AddValuesToList(List<string> list, object values)
        {
            switch (values)
            {
                case string str:
                    var sliceOfValues = str.Split(',');
                    list.AddRange(sliceOfValues);
                    break;
                case List<string> stringList:
                    list.AddRange(stringList);
                    break;
                default:
                    throw new ArgumentException("Invalid data passed in to AddValuesToList()");
            }
        }

        // IsVocabEntryValid - This function will take in a vocabulary and a
        // value and return true if it is found and false if it is not found.
        public static bool IsVocabEntryValid(Dictionary<string, bool> vocab, string s)
        {
            return vocab.ContainsKey(s) && vocab[s];
        }
    }
}

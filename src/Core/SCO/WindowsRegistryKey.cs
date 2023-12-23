using Cti.Stix.Types;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The Registry Key object represents the properties of a Windows registry key. As all properties of 
    /// this object are optional, at least one of the properties defined below MUST be included when using 
    /// this object.
    /// </summary>
    public class WindowsRegistryKey : ScoStix
    {
        public WindowsRegistryKey() { ObjectType = "windows-registry-key"; }

        /// <summary>
        /// Specifies the full registry key including the hive.
        /// The value of the key, including the hive portion, SHOULD be case-preserved. The hive portion of 
        /// the key MUST be fully expanded and not truncated; e.g., HKEY_LOCAL_MACHINE must be used instead 
        /// of HKLM.
        /// </summary>
        [JsonProperty("key")]
        [BsonElement("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Specifies the values found under the registry key.
        /// </summary>
        [JsonProperty("values")]
        [BsonElement("values")]
        public WindowsRegistryValueType? Values { get; set; }

        /// <summary>
        /// Specifies the last date/time that the registry key was modified.
        /// </summary>
        [JsonProperty("modified_time")]
        [BsonElement("modified_time")]
        public DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// Specifies a reference to the user account that created the registry key.
        /// The object referenced in this property MUST be of type user-account.
        /// </summary>
        [JsonProperty("creator_user_ref")]
        [BsonElement("creator_user_ref")]
        public string? CreatorUserRef { get; set; }

        /// <summary>
        /// Specifies the number of subkeys contained under the registry key.
        /// </summary>
        [JsonProperty("number_of_subkeys")]
        [BsonElement("number_of_subkeys")]
        public int? NumberOfSubkeys { get; set; }


    }
}

using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Cti.Stix.Types
{
    public class GranularMarking
    {
        [JsonProperty("lang")]
        [BsonElement("lang")]
        public string? Lang { get; set; }

        /// <summary>
        /// Marking reference associated with the granular marking
        /// </summary>
        [JsonProperty("marking_ref")]
        [BsonElement("marking_ref")]
        public string? MarkingRef { get; set; }

        /// <summary>
        /// List of selectors associated with the granular marking
        /// </summary>
        [JsonProperty("selectors")]
        [BsonElement("selectors")]
        public List<string> Selectors { get; set; } = new List<string>();

        public string Selector { get; set; }
        public string Control { get; set; }
    }
}

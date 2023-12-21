using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cti.Stix.Types
{
    /// <summary>
    /// External references are used to describe pointers to information represented outside of STIX. 
    /// For example, a Malware object could use an external reference to indicate an ID for that malware in an external database or a report could use references to represent source material.
    /// The JSON MTI serialization uses the JSON Object type[RFC8259] when representing external-reference.
    /// </summary>
    public class ExternalReference
    {
        [JsonProperty("source_name")]
        [BsonElement("source_name")]
        public string? SourceName { get; set; }

        /// <summary>
        /// Description of the external reference
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL associated with the external reference
        /// </summary>
        [JsonProperty("url")]
        [BsonElement("url")]
        public string? URL { get; set; }

        /// <summary>
        /// Hashes associated with the external reference (map of string keys to string values)
        /// </summary>
        [JsonProperty("hashes")]
        [BsonElement("hashes")]
        public Dictionary<string, string>? Hashes { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// External ID associated with the external reference
        /// </summary>
        [JsonProperty("external_id")]
        [BsonElement("external_id")]
        public string? ExternalID { get; set; }

    }
}

using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The MAC Address object represents a single Media Access Control (MAC) address.
    /// </summary>
    public class MacAddress : ScoStix
    {
        public MacAddress()
        {
            ObjectType = "mac-addr";
        }

        /// <summary>
        /// Specifies the value of a single MAC address.
        /// The MAC address value MUST be represented as a single colon-delimited, lowercase MAC-48 address, which MUST include leading zeros for each octet.
        /// Example: 00:00:ab:cd:ef:01
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("value")]
        [BsonElement("value")]
        public string Value { get; set; }
    }
}

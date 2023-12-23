using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// This object represents the properties of an Autonomous System (AS).
    /// </summary>
    public class AutonomousSystem : ScoStix
    {
        public AutonomousSystem()
        {
            ObjectType = "autonomous-system";
        }

        /// <summary>
        /// Specifies the number assigned to the AS. Such assignments are typically performed by a Regional Internet Registry (RIR).
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("number")]
        [BsonElement("number")]
        public int Number { get; set; }

        /// <summary>
        /// Specifies the name of the AS.
        /// </summary>
        [JsonProperty("name")]
        [BsonElement("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Specifies the name of the Regional Internet Registry (RIR) that assigned the number to the AS.
        /// </summary>
        [JsonProperty("rir")]
        [BsonElement("rir")]
        public string? Rir { get; set; }
    }
}

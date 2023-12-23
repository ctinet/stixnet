using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The URL object represents the properties of a uniform resource locator (URL).
    /// </summary>
    public class Url : ScoStix
    {
        public Url() { ObjectType = "url"; }

        /// <summary>
        /// Specifies the value of the URL. The value of this property MUST conform to [RFC3986], 
        /// more specifically section 1.1.3 with reference to the definition for "Uniform Resource Locator".
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("value")]
        [BsonElement("value")]
        public string Value { get; set; }
    }
}

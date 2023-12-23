using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The Software object represents high-level properties associated with software, including software products.
    /// </summary>
    public class Software : ScoStix
    {
        public Software() { ObjectType = "software"; }

        /// <summary>
        /// Specifies the name of the software.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the Common Platform Enumeration (CPE) entry for the software, if available. The value for this 
        /// property MUST be a CPE v2.3 entry from the official NVD CPE Dictionary [NVD] .
        /// While the CPE dictionary does not contain entries for all software, whenever it does contain an identifier 
        /// for a given instance of software, this property SHOULD be present.
        /// </summary>
        [JsonProperty("cpe")]
        [BsonElement("cpe")]
        public string? Cpe { get; set; }

        /// <summary>
        /// Specifies the Software Identification (SWID) Tags [SWID] entry for the software, if available. The tag attribute, 
        /// tagId, a globally unique identifier, SHOULD be used as a proxy identifier of the tagged product.
        /// </summary>
        [JsonProperty("swid")]
        [BsonElement("swid")]
        public string? Swid { get; set; }

        /// <summary>
        /// Specifies the languages supported by the software. The value of each list member MUST be a language code conformant to [RFC5646].
        /// </summary>
        [JsonProperty("languages")]
        [BsonElement("languages")]
        public List<string>? Languages { get; set; }

        /// <summary>
        /// Specifies the name of the vendor of the software.
        /// </summary>
        [JsonProperty("vendor")]
        [BsonElement("vendor")]
        public string? Vendor { get; set; }

        /// <summary>
        /// Specifies the version of the software.
        /// </summary>
        [JsonProperty("version")]
        [BsonElement("version")]
        public string? Version { get; set; }


    }
}

using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// The Incident object in STIX 2.1 is a stub. It is included to support basic use cases but does not contain properties to 
    /// represent metadata about incidents. Future STIX 2 releases will expand it to include these capabilities.  It is suggested 
    /// that it is used as an extension point for an Incident object defined using the extension facility described in section 7.3.
    /// </summary>
    public class Incident : SdoStix
    {
        public Incident(string objectType = "incident") { ObjectType = objectType; }

        /// <summary>
        /// A name used to identify the Incident.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Incident, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /*
         
        Embedded Relationships:     created_by_ref         identifier (of type identity)
                                    object_marking_refs     list of type identifier (of type marking-definition)
        
        Common Relationships:       duplicate-of, derived-from, related-to 
         
         */
    }
}

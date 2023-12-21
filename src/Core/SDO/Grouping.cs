using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// A Grouping object explicitly asserts that the referenced STIX Objects have a shared context, unlike a STIX Bundle (which explicitly conveys no context).
    /// A Grouping object should not be confused with an intelligence product, which should be conveyed via a STIX Report.
    /// </summary>
    public class Grouping : SdoStix
    {
        public Grouping(string objectType = "grouping")
        {
            ObjectType = objectType;
        }

        /// <summary>
        /// A name used to identify the Grouping.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Grouping, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A short descriptor of the particular context shared by the content referenced by the Grouping.
        /// The value for this property SHOULD come from the grouping-context-ov open vocabulary.
        /// </summary>
        [JsonProperty("context")]
        [BsonElement("context")]
        public string? Context { get; set; }


        /// <summary>
        /// Specifies the STIX Objects that are referred to by this Grouping.
        /// </summary>
        [JsonProperty("object_refs")]
        [BsonElement("object_refs")]
        public List<string> ObjectRefs { get; set; }

        /*
         
        Embedded Relationships:     created_by_ref          identifier (of type identity)
                                    object_marking_refs     list of type identifier (of type marking-definition)
                                    object_refs             list of type identifier (of type STIX Object)
        
        Common Relationships:       duplicate-of
                                    derived-from
                                    related-to
         
         */

    }
}

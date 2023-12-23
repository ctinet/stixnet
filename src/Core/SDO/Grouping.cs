using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// A Grouping object explicitly asserts that the referenced STIX Objects have a shared context, unlike a STIX Bundle (which explicitly conveys no context).
    /// A Grouping object should not be confused with an intelligence product, which should be conveyed via a STIX Report.
    /// 
    /// A STIX Grouping object might represent a set of data that, in time, given sufficient analysis, would mature to convey an incident or threat report as a 
    /// STIX Report object. For example, a Grouping could be used to characterize an ongoing investigation into a security event or incident. A Grouping object 
    /// could also be used to assert that the referenced STIX Objects are related to an ongoing analysis process, such as when a threat analyst is collaborating 
    /// with others in their trust community to examine a series of Campaigns and Indicators. The Grouping SDO contains a list of references to SDOs, SCOs, SROs, 
    /// and SMOs, along with an explicit statement of the context shared by the content, a textual description, and the name of the grouping.
    /// </summary>
    public class Grouping : SdoStix
    {
        public Grouping()
        {
            ObjectType = "grouping";
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

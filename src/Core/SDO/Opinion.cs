using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// An Opinion is an assessment of the correctness of the information in a STIX Object produced by a different entity. 
    /// The primary property is the opinion property, which captures the level of agreement or disagreement using a fixed 
    /// scale. That fixed scale also supports a numeric mapping to allow for consistent statistical operations across opinions.
    /// </summary>
    public class Opinion : SdoStix
    {
        public Opinion() { ObjectType = "opinion"; }

        /// <summary>
        /// An explanation of why the producer has this Opinion. For example, if an Opinion of strongly-disagree is given,
        /// the explanation can contain an explanation of why the Opinion producer disagrees and what evidence they have 
        /// for their disagreement.
        /// </summary>
        [JsonProperty("explanation")]
        [BsonElement("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// The name of the author(s) of this Opinion (e.g., the analyst(s) that created it).
        /// </summary>
        [JsonProperty("authors")]
        [BsonElement("authors")]
        public List<string>? Authors { get; set; }

        /// <summary>
        /// The opinion that the producer has about all of the STIX Object(s) listed in the object_refs property.
        /// The values of this property MUST come from the opinion-enum enumeration.
        /// strongly-disagree = 1, disagree = 2, neutral = 3, agree = 5, strongly-agree = 5
        /// </summary>
        [JsonProperty("opinion")]
        [BsonElement("opinion")]
        public int? _Opinion { get; set; }

        /// <summary>
        /// The STIX Objects that the Opinion is being applied to.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("object_refs")]
        [BsonElement("object_refs")]
        public List<string> ObjectRefs { get; set; }

        /*
         
         Embedded Relationships

created_by_ref

identity

object_marking_refs

list of type identifier (of type marking-definition)

object_refs

list of type identifier (of type any STIX Object type)

Common Relationships

duplicate-of, derived-from, related-to

         */

    }
}

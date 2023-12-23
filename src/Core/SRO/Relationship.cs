using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cti.Stix.Core.SRO
{
    /// <summary>
    /// The Relationship object is used to link together two SDOs or SCOs in order to describe how they are related to each other. 
    /// If SDOs and SCOs are considered "nodes" or "vertices" in the graph, the Relationship Objects (SROs) represent "edges".
    /// 
    /// STIX defines many relationship types to link together SDOs and SCOs. These relationships are contained in the "Relationships" 
    /// table under each SDO and SCO definition. Relationship types defined in the specification SHOULD be used to ensure consistency. 
    /// An example of a specification-defined relationship is that an indicator indicates a campaign. That relationship type is listed 
    /// in the Relationships section of the Indicator SDO definition.
    /// 
    /// STIX also allows relationships from any SDO or SCO to any SDO or SCO that have not been defined in this specification. These 
    /// relationships MAY use the related-to relationship type or MAY use a user-defined relationship type. As an example, a user might 
    /// want to link malware directly to a tool. They can do so using related-to to say that the Malware is related to the Tool but not 
    /// describe how, or they could use delivered-by (a user-defined name they determined) to indicate more detail.
    /// 
    /// Note that some relationships in STIX may seem like "shortcuts". For example, an Indicator doesn't really detect a Campaign: it 
    /// detects activity (Attack Patterns, Malware, Infrastructure, etc.) that are often used by that campaign. While some analysts might 
    /// want all of the source data and think that shortcuts are misleading, in many cases it's helpful to provide just the key points 
    /// (shortcuts) and leave out the low-level details. In other cases, the low-level analysis may not be known or sharable, while the 
    /// high-level analysis is. For these reasons, relationships that might appear to be "shortcuts" are not excluded from STIX.
    /// </summary>
    public class Relationship : SroStix
    {
        public Relationship() { ObjectType = "Relationship"; }

        /// <summary>
        /// The name used to identify the type of Relationship. This value SHOULD be an exact value listed in the relationships for the 
        /// source and target SDO, but MAY be any string. The value of this property MUST be in ASCII and is limited to characters a–z 
        /// (lowercase ASCII), 0–9, and hyphen (-).
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("relationship_type")]
        [BsonElement("relationship_type")]
        public string RelationshipType { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Relationship, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The id of the source (from) object. The value MUST be an ID reference to an SDO or SCO (i.e., it cannot point to an SRO, Bundle, Language Content, 
        /// or Marking Definition).
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("source_ref")]
        [BsonElement("source_ref")]
        public string SourceRef { get; set; }

        /// <summary>
        /// The id of the target (to) object. The value MUST be an ID reference to an SDO or SCO (i.e., it cannot point to an SRO, Bundle, Language Content, 
        /// or Marking Definition).
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("target_ref")]
        [BsonElement("target_ref")]
        public string TargetRef { get; set; }

        /// <summary>
        /// This optional timestamp represents the earliest time at which the Relationship between the objects exists.If this property is a future timestamp, 
        /// at the time the start_time property is defined, then this represents an estimate by the producer of the intelligence of the earliest time at which 
        /// relationship will be asserted to be true.
        /// 
        /// If it is not specified, then the earliest time at which the relationship between the objects exists is not defined.
        /// </summary>
        [JsonProperty("start_time")]
        [BsonElement("start_time")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The latest time at which the Relationship between the objects exists. If this property is a future timestamp, at the time the stop_time property is 
        /// defined, then this represents an estimate by the producer of the intelligence of the latest time at which relationship will be asserted to be true.
        /// 
        /// If start_time and stop_time are both defined, then stop_time MUST be later than the start_time value.
        /// 
        /// If stop_time is not specified, then the latest time at which the relationship between the objects exists is either not known, not disclosed, or has 
        /// no defined stop time.
        /// </summary>
        [JsonProperty("stop_time")]
        [BsonElement("stop_time")]
        public DateTime? stop_time { get; set; }



    }
}

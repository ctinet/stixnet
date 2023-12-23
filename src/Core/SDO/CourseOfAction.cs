using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// The Course of Action object in STIX 2.1 is a stub. It is included to support basic use cases (such as sharing prose courses of action) but does not support 
    /// the ability to represent automated courses of action or contain properties to represent metadata about courses of action. Future STIX 2 releases will expand 
    /// it to include these capabilities.
    /// 
    /// A Course of Action is an action taken either to prevent an attack or to respond to an attack that is in progress. It may describe technical, automatable responses 
    /// (applying patches, reconfiguring firewalls) but can also describe higher level actions like employee training or policy changes. 
    /// For example, a course of action to mitigate a vulnerability could describe applying the patch that fixes it.
    /// 
    /// The Course of Action SDO contains a textual description of the action; a reserved action property also serves as a placeholder for future inclusion of machine 
    /// automatable courses of action.
    /// </summary>
    public class CourseOfAction : SdoStix
    {
        public CourseOfAction()
        {
            ObjectType = "course-of-action";
        }

        /// <summary>
        /// A name used to identify the Course of Action.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Course of Action, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /*
         
        Embedded Relationships:     created_by_ref          identifier (of type identity)
                                    object_marking_refs     list of type identifier (of type marking-definition)
        
        Common Relationships:       duplicate-of, derived-from, related-to
        
        Source                  Relationship Type           Target          Description
        ---------------------------------------------------------------------------------------------------------------------------------------------------------------------
        course-of-action        investigates                indicator       This Relationship describes that the Course of Action can be used to investigate the Indicator.
        course-of-action        mitigates                   attack-pattern, This Relationship describes that the Course of Action can mitigate (e.g. respond to a threat) 
                                                            indicator,      the related Attack Pattern, Indicator, Malware, Vulnerability, or Tool.
                                                            malware,        For example, a mitigates Relationship from a Course of Action object to a Malware object 
                                                            tool,           indicates that the course of action mitigates the malware.
                                                            vulnerability
        course-of-action        remediates                  malware,        This Relationship describes that the Course of Action can be used to remediate 
                                                            vulnerability   (e.g. clean up) the malware or vulnerability
         */
    }
}

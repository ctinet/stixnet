using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /*
        class CourseOfAction(allow_custom=False, **kwargs)
            For more detailed information on this object’s properties, see the STIX 2.1 specification.

        Properties:	
            name (String, required)
            description (String)
            
     */
    public class CourseOfAction : SdoStix
    {
        public CourseOfAction(string objectType = "course-of-action")
        {
            ObjectType = objectType;
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

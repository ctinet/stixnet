using Cti.Stix.Types;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// Indicators contain a pattern that can be used to detect suspicious or malicious cyber activity. For example, an Indicator may be used to 
    /// represent a set of malicious domains and use the STIX Patterning Language (see section 9) to specify these domains.
    /// </summary>
    public class Indicator : SdoStix
    {

        public Indicator(string objectType = "indicator") { ObjectType = objectType; }
        
        /// <summary>
        /// A name used to identify the Indicator.
        /// </summary>
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Indicator, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A name used to identify the Indicator.
        /// </summary>
        [JsonProperty("indicator_types")]
        [BsonElement("indicator_types")]
        public string IndicatorTypes { get; set; }

        /// <summary>
        /// The detection pattern for this Indicator MAY be expressed as a STIX Pattern as specified in section 9 or another appropriate language such as SNORT, YARA, etc.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("pattern")]
        [BsonElement("pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// The pattern language used in this indicator.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("pattern_type")]
        [BsonElement("pattern_type")]
        public string PatternType { get; set; }

        /// <summary>
        /// The version of the pattern language that is used for the data in the pattern property which MUST match the type of pattern data included in the pattern property.
        /// </summary>
        [JsonProperty("pattern_version")]
        [BsonElement("pattern_version")]
        public string? PatternVersion { get; set; }

        /// <summary>
        /// The time from which this Indicator is considered a valid indicator of the behaviors it is related or represents.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("valid_from")]
        [BsonElement("valid_from")]
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// The time at which this Indicator should no longer be considered a valid indicator of the behaviors it is related to or represents.
        /// </summary>
        [JsonProperty("valid_until")]
        [BsonElement("valid_until")]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// The kill chain phase(s) to which this Indicator corresponds.
        /// </summary>
        [JsonProperty("kill_chain_phases")]
        [BsonElement("kill_chain_phases")]
        public List<KillChainPhase>? KillChainPhases { get; set; }

        /*
         
        Embedded Relationships:         created_by_ref          identifier (of type identity)
                                        object_marking_refs     list of type identifier (of type marking-definition)

        Common Relationships:           duplicate-of, derived-from, related-to

        Source              Relationship Type           Target              Description
        -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        indicator           indicates                   attack-pattern,     This Relationship describes that the Indicator can detect evidence of the related Attack Pattern, 
                                                        campaign,           Campaign, Infrastructure, Intrusion Set, Malware, Threat Actor, or Tool. This evidence may not be 
                                                        infrastructure,     direct: for example, the Indicator may detect secondary evidence of the Campaign, such as malware 
                                                        intrusion-set,      or behavior commonly used by that Campaign.
                                                        malware,            For example, an indicates Relationship from an Indicator to a Campaign object representing Glass 
                                                        threat-actor,       Gazelle means that the Indicator is capable of detecting evidence of Glass Gazelle, such as command 
                                                        tool                and control IPs commonly used by that Campaign.

        
        indicator           based-on                    observed-data       This relationship describes that the indicator was created based on information from an observed-data 
                                                                            object. For example, an indicator may be created based upon the observation of a spearphishing email 
                                                                            or created based upon analysis performed on a piece of malware or adversary infrastructure.
        
        Reverse Relationships:

        Source              Relationship Type           Target              Description
        -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        course-of-action    investigates                indicator           See forward relationship for definition.
        course-of-action    mitigates                   indicator           See forward relationship for definition.
         
         
         */
    }
}

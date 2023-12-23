using Cti.Stix.Types;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// Attack Patterns are a type of TTP that describe ways that adversaries attempt to compromise targets. Attack Patterns are used to help 
    /// categorize attacks, generalize specific attacks to the patterns that they follow, and provide detailed information about how attacks 
    /// are performed. An example of an attack pattern is "spear phishing": a common type of attack where an attacker sends a carefully 
    /// crafted e-mail message to a party with the intent of getting them to click a link or open an attachment to deliver malware. 
    /// Attack Patterns can also be more specific; spear phishing as practiced by a particular threat actor (e.g., they might generally say
    /// that the target won a contest) can also be an Attack Pattern.
    /// </summary>
    public class AttackPattern : SdoStix
    {
        public AttackPattern()
        {
            ObjectType = "attack-pattern";
        }

        /// <summary>
        /// A name used to identify the Attack Pattern.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Attack Pattern, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Alternative names used to identify this Attack Pattern.
        /// </summary>
        [JsonProperty("aliases")]
        [BsonElement("aliases")]
        public List<string>? Aliases { get; set; }

        /// <summary>
        /// The list of Kill Chain Phases for which this Attack Pattern is used.
        /// </summary>
        [JsonProperty("kill_chain_phases")]
        [BsonElement("kill_chain_phases")]
        public List<KillChainPhase>? KillChainPhases { get; set; }


        /// <summary>
        /// A list of external references which refer to non-STIX information. This property MAY be used to provide one or more Attack Pattern identifiers, 
        /// such as a CAPEC ID. When specifying a CAPEC ID, the source_name property of the external reference MUST be set to capec and the external_id 
        /// property MUST be formatted as CAPEC-[id].
        /// </summary>
        [JsonProperty("external_references")]
        [BsonElement("external_references")]
        public override List<ExternalReference> ExternalReferences { get; set; }

        /*
           Embedded Relationships
               created_by_ref              identifier (of type identity)
               object_marking_refs         list of type identifier (of type marking-definition)
           Common Relationships
               duplicate-of, derived-from, related-to
        */

    }
}

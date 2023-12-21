using Cti.Stix.Types;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// The Infrastructure SDO represents a type of TTP and describes any systems, software services and any associated physical or 
    /// virtual resources intended to support some purpose (e.g., C2 servers used as part of an attack, device or server that are 
    /// part of defense, database servers targeted by an attack, etc.). While elements of an attack can be represented by other 
    /// SDOs or SCOs, the Infrastructure SDO represents a named group of related data that constitutes the infrastructure.
    /// </summary>
    public class Infrastructure : SdoStix
    {
        public Infrastructure(string objectType = "infrastructure") { ObjectType = objectType;  }

        /// <summary>
        /// A name or characterizing text used to identify the Infrastructure.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Infrastructure, potentially including its purpose, how it 
        /// is being used, how it relates to other intelligence activities captured in related objects, and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The type of infrastructure being described.
        /// </summary>
        [JsonProperty("infrastructure_types")]
        [BsonElement("infrastructure_types")]
        public List<string>? InfrastructureTypes { get; set; }

        /// <summary>
        /// Alternative names used to identify this Infrastructure.
        /// </summary>
        [JsonProperty("aliases")]
        [BsonElement("aliases")]
        public List<string>? Aliases { get; set; }

        /// <summary>
        /// The list of Kill Chain Phases for which this Infrastructure is used.
        /// </summary>
        [JsonProperty("kill_chain_phases")]
        [BsonElement("kill_chain_phases")]
        public List<KillChainPhase>? KillChainPhases { get; set; }

        /// <summary>
        /// The time that this Infrastructure was first seen performing malicious activities.
        /// </summary>
        [JsonProperty("first_seen")]
        [BsonElement("first_seen")]
        public DateTime? FirstSeen { get; set; }

        /// <summary>
        /// The time that this Infrastructure was last seen performing malicious activities.
        /// If this property and the first_seen property are both defined, then this property MUST be greater than or equal to the timestamp in the first_seen property.
        /// </summary>
        [JsonProperty("last_seen")]
        [BsonElement("last_seen")]
        public DateTime? LastSeen { get; set; }

        /*
         
        
            Embedded Relationships

            created_by_ref          identifier (of type identity)
            object_marking_refs     list of type identifier (of type marking-definition)

            Common Relationships

            duplicate-of, derived-from, related-to

            Source                  Relationship Type                   Target                                  Description
            ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            infrastructure          communicates-with                   infrastructure, ipv4-addr,              This Relationship documents that this infrastructure instance communicates with 
                                                                        ipv6-addr, domain-name, url             the defined network addressable resource.
                                                                                                                For example, a botnet could communicate with a crypto-currency mining pool. This 
                                                                                                                does not mean that the pool is a part of this infrastructure.
            infrastructure          consists-of                         infrastructure, observed-data,          This Relationship documents the objects that are used to make up an infrastructure 
                                                                        <All STIX Cyber-observable Objects>     instance, such as ipv4-addr, ipv6-addr, domain-name, url. An infrastructure 
                                                                                                                instance consists of zero or more objects.
                                                                                                                While not all SCO types will make sense as infrastructure, allowing any 
                                                                                                                type of SCO prevents artificially restricting what could be used.
            infrastructure          controls                            infrastructure, malware                 This Relationship describes that this infrastructure controls some other 
                                                                                                                infrastructure or a malware instance (or family).

            infrastructure          delivers                            malware                                 This Relationship describes that this infrastructure is used to actively deliver 
                                                                                                                a malware instance (or family).

            infrastructure          has                                 vulnerability                           This Relationship describes that this specific Infrastructure has this specific 
                                                                                                                Vulnerability.
                                                                                                                For example, a web server may not have been patched and currently is impacted by a CVE.
            infrastructure          hosts                               tool, malware                           This Relationship describes that this infrastructure has a tool running on it or is 
                                                                                                                used to passively host the tool / malware.
                                                                                                                For example, an SSH server may be hosted on a piece of infrastructure.
            infrastructure          located-at                          location                                This Relationship describes that the infrastructure originates from the related location.
                                                                                                                For example, a located-at relationship from the Red Orca C2 infrastructure to a Location 
                                                                                                                representing North America means that the Red Orca C2 Infrastructure appears to originate 
                                                                                                                from or is located in North America.
            infrastructure          uses                                infrastructure                          This Relationship describes that this infrastructure uses this other infrastructure to achieve its objectives.

            Reverse Relationships:

            Source                  Relationship Type                   Target                                  Description
            ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            campaign,               compromises                         infrastructure                          See forward relationship for definition.
            intrusion-set,
            threat-actor

            malware                 beacons-to, exfiltrates-to          infrastructure                          See forward relationship for definition.

            intrusion-set,          hosts                               infrastructure                          See forward relationship for definition.
            threat-actor    

            indicator               indicates                           infrastructure                          See forward relationship for definition.

            intrusion-set,          owns                                infrastructure                          See forward relationship for definition.
            threat-actor

            malware,                targets                             infrastructure                          See forward relationship for definition.
            tool

            campaign,               uses                                infrastructure                          See forward relationship for definition.
            intrusion-set,
            malware,  
            threat-actor, 
            tool
        
         */
    }
}

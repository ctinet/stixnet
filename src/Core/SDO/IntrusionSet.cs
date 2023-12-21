using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// An Intrusion Set is a grouped set of adversarial behaviors and resources with common properties that is believed to be orchestrated by a 
    /// single organization. An Intrusion Set may capture multiple Campaigns or other activities that are all tied together by shared attributes 
    /// indicating a commonly known or unknown Threat Actor. New activity can be attributed to an Intrusion Set even if the Threat Actors behind 
    /// the attack are not known. Threat Actors can move from supporting one Intrusion Set to supporting another, or they may support multiple Intrusion Sets.
    /// </summary>
    public class IntrusionSet : SdoStix
    {
        public IntrusionSet(string objectType = "intrusion-set") { ObjectType = objectType; }

        /// <summary>
        /// A name used to identify this Intrusion Set.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Intrusion Set, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Alternative names used to identify this Intrusion Set.
        /// </summary>
        [JsonProperty("aliases")]
        [BsonElement("aliases")]
        public List<string>? Aliases { get; set; }

        /// <summary>
        /// The time that this Intrusion Set was first seen.
        /// </summary>
        [JsonProperty("first_seen")]
        [BsonElement("first_seen")]
        public DateTime? FirstSeen { get; set; }

        /// <summary>
        /// The time that this Intrusion Set was last seen.
        /// </summary>
        [JsonProperty("last_seen")]
        [BsonElement("last_seen")]
        public DateTime? LastSeen { get; set; }

        /// <summary>
        /// The high-level goals of this Intrusion Set, namely, what are they trying to do. For example, they may be motivated by personal gain, but their 
        /// goal is to steal credit card numbers. To do this, they may execute specific Campaigns that have detailed objectives like compromising point of 
        /// sale systems at a large retailer.
        /// </summary>
        [JsonProperty("goals")]
        [BsonElement("goals")]
        public List<string>? Goals { get; set; }

        /// <summary>
        /// This property specifies the organizational level at which this Intrusion Set typically works, which in turn determines the resources available 
        /// to this Intrusion Set for use in an attack.
        /// </summary>
        [JsonProperty("resource_level")]
        [BsonElement("resource_level")]
        public string? ResourceLevel { get; set; }

        /// <summary>
        /// The primary reason, motivation, or purpose behind this Intrusion Set. The motivation is why the Intrusion Set wishes to achieve the goal (what 
        /// they are trying to achieve).
        /// </summary>
        [JsonProperty("primary_motivation")]
        [BsonElement("primary_motivation")]
        public string? PrimaryMotivation { get; set; }

        /// <summary>
        /// The secondary reasons, motivations, or purposes behind this Intrusion Set. These motivations can exist as an equal or near-equal cause to the 
        /// primary motivation. However, it does not replace or necessarily magnify the primary motivation, but it might indicate additional context. The 
        /// position in the list has no significance.
        /// </summary>
        [JsonProperty("secondary_motivations")]
        [BsonElement("secondary_motivations")]
        public List<string>? SecondaryMotivation { get; set; }

        /*
         
         
            Embedded Relationships:         created_by_ref          identifier (of type identity)
                                            object_marking_refs     list of type identifier (of type marking-definition)

            Common Relationships:           duplicate-of, derived-from, related-to

            Source                          Relationship Type                       Target                                  Description
            ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            intrusion-set                   attributed-to                           threat-actor                            This Relationship describes that the related Threat Actor is involved 
                                                                                                                            in carrying out the Intrusion Set.
                                                                                                                            For example, an attributed-to Relationship from the Red Orca Intrusion 
                                                                                                                            Set to the Urban Fowl Threat Actor means that the actor carried out or 
                                                                                                                            was involved in some of the activity described by the Intrusion Set.

            intrusion-set                   compromises                             infrastructure                          This Relationship describes that the Intrusion Set compromises the related 
                                                                                                                            Infrastructure.

            intrusion-set                   hosts, owns                             infrastructure                          This Relationship describes that the Intrusion Set hosts or owns the related 
                                                                                                                            Infrastructure (e.g. an actor that rents botnets to other threat actors).

            intrusion-set                   originates-from                         location                                This Relationship describes that the Intrusion Set originates from the related 
                                                                                                                            location and SHOULD NOT be used to define attribution.
                                                                                                                            For example, an originates-from relationship from the Red Orca Intrusion Set to a 
                                                                                                                            Location representing North America means that the Red Orca Intrusion Set appears 
                                                                                                                            to originate from or is located in North America.

            intrusion-set                   targets                                 identity, location, vulnerability       This Relationship describes that the Intrusion Set uses exploits of the related 
                                                                                                                            Vulnerability or targets the type of victims described by the related Identity or Location.
                                                                                                                            For example, a targets Relationship from the Red Orca Intrusion Set to a Vulnerability 
                                                                                                                            in a blogging platform indicates that attacks performed as part of Red Orca often 
                                                                                                                            exploit that Vulnerability.
                                                                                                                            Similarly, a targets Relationship from the Red Orca Intrusion Set to an Identity 
                                                                                                                            describing the energy sector in the United States means that the Intrusion Set typically 
                                                                                                                            carries out attacks against targets in that sector.

            intrusion-set                   uses                                    attack-pattern, infrastructure,         This Relationship describes that attacks carried out as part of the Intrusion Set 
                                                                                    malware, tool                           typically use the related Attack Pattern, Infrastructure, Malware, or Tool.
                                                                                                                            For example, a uses Relationship from the Red Orca Intrusion Set to the xInject Malware 
                                                                                                                            indicates that xInject is often used during attacks attributed to that Intrusion Set.

            Reverse Relationships
        
            Source                          Relationship Type                       Target                                  Description
            ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            campaign                        attributed-to                           intrusion-set                           See forward relationship for definition.
            malware                         authored-by                             intrusion-set                           See forward relationship for definition.
            indicator                       indicates                               intrusion-set                           See forward relationship for definition.
         
         
         */
    }
}

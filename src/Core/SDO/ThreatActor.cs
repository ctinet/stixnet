using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// Threat Actors are actual individuals, groups, or organizations believed to be operating with malicious intent. A Threat Actor is not an Intrusion 
    /// Set but may support or be affiliated with various Intrusion Sets, groups, or organizations over time.
    /// 
    /// Threat Actors leverage their resources, and possibly the resources of an Intrusion Set, to conduct attacks and run Campaigns against targets.
    /// 
    /// Threat Actors can be characterized by their motives, capabilities, goals, sophistication level, past activities, resources they have access to, 
    /// and their role in the organization.
    /// </summary>
    public class ThreatActor : SdoStix
    {
        public ThreatActor() { ObjectType = "threat-actor"; }

        /// <summary>
        /// A name used to identify this Threat Actor or Threat Actor group.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Threat Actor, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The type(s) of this threat actor.
        /// 
        /// The values for this property SHOULD come from the threat-actor-type-ov open vocabulary.
        /// </summary>
        [JsonProperty("threat_actor_types")]
        [BsonElement("threat_actor_types")]
        public List<string>? ThreatActorTypes { get; set; }

        /// <summary>
        /// A list of other names that this Threat Actor is believed to use.
        /// </summary>
        [JsonProperty("aliases")]
        [BsonElement("aliases")]
        public List<string>? Aliases { get; set; }

        /// <summary>
        /// The time that this Threat Actor was first seen.
        /// This property is a summary property of data from sightings and other data that may or may not be available in STIX. If new sightings are received
        /// that are earlier than the first seen timestamp, the object may be updated to account for the new data.
        /// </summary>
        [JsonProperty("first_seen")]
        [BsonElement("first_seen")]
        public DateTime? FirstSeen { get; set; }

        /// <summary>
        /// The time that this Threat Actor was last seen.
        /// 
        /// This property is a summary property of data from sightings and other data that may or may not be available in STIX. If new sightings are received 
        /// that are later than the last seen timestamp, the object may be updated to account for the new data.
        /// 
        /// If this property and the first_seen property are both defined, then this property MUST be greater than or equal to the timestamp in the first_seen property.
        /// </summary>
        [JsonProperty("last_seen")]
        [BsonElement("last_seen")]
        public DateTime? LastSeen { get; set; }

        /// <summary>
        /// A list of roles the Threat Actor plays.
        /// The values for this property SHOULD come from the threat-actor-role-ov open vocabulary.
        /// </summary>
        [JsonProperty("roles")]
        [BsonElement("roles")]
        public List<string>? Roles { get; set; }

        /// <summary>
        /// The high-level goals of this Threat Actor, namely, what are they trying to do. For example, they may be motivated by personal gain, but their goal is to steal 
        /// credit card numbers. To do this, they may execute specific Campaigns that have detailed objectives like compromising point of sale systems at a large retailer.
        /// </summary>
        [JsonProperty("goals")]
        [BsonElement("goals")]
        public List<string>? Goals { get; set; }

        /// <summary>
        /// The skill, specific knowledge, special training, or expertise a Threat Actor must have to perform the attack.
        /// The value for this property SHOULD come from the threat-actor-sophistication-ov open vocabulary.
        /// </summary>
        [JsonProperty("sophistication")]
        [BsonElement("sophistication")]
        public string? Sophistication { get; set; }

        /// <summary>
        /// The organizational level at which this Threat Actor typically works, which in turn determines the resources available to this Threat Actor for use in an attack. 
        /// This attribute is linked to the sophistication property — a specific resource level implies that the Threat Actor has access to at least a specific sophistication level.
        /// 
        /// The value for this property SHOULD come from the attack-resource-level-ov open vocabulary.
        /// </summary>
        [JsonProperty("resource_level")]
        [BsonElement("resource_level")]
        public string? ResourceLevel { get; set; }

        /// <summary>
        /// The primary reason, motivation, or purpose behind this Threat Actor. The motivation is why the Threat Actor wishes to achieve the goal (what they are trying to achieve).
        /// For example, a Threat Actor with a goal to disrupt the finance sector in a country might be motivated by ideological hatred of capitalism.
        /// The value for this property SHOULD come from the attack-motivation-ov open vocabulary.
        /// </summary>
        [JsonProperty("primary_motivation")]
        [BsonElement("primary_motivation")]
        public string? PrimaryMotivation { get; set; }

        /// <summary>
        /// This property specifies the secondary reasons, motivations, or purposes behind this Threat Actor.
        /// 
        /// These motivations can exist as an equal or near-equal cause to the primary motivation. However, it does not replace or necessarily magnify the primary motivation, but it 
        /// might indicate additional context. The position in the list has no significance.
        /// 
        /// The value for this property SHOULD come from the attack-motivation-ov open vocabulary.
        /// </summary>
        [JsonProperty("secondary_motivations")]
        [BsonElement("secondary_motivations")]
        public List<string>? SecondaryMotivations { get; set; }

        /// <summary>
        /// The personal reasons, motivations, or purposes of the Threat Actor regardless of organizational goals.
        /// 
        /// Personal motivation, which is independent of the organization’s goals, describes what impels an individual to carry out an attack. Personal motivation may align with the 
        /// organization’s motivation—as is common with activists—but more often it supports personal goals. For example, an individual analyst may join a Data Miner corporation 
        /// because his or her skills may align with the corporation’s objectives. But the analyst most likely performs his or her daily work toward those objectives for personal 
        /// reward in the form of a paycheck. The motivation of personal reward may be even stronger for Threat Actors who commit illegal acts, as it is more difficult for someone 
        /// to cross that line purely for altruistic reasons. The position in the list has no significance.
        /// 
        /// The values for this property SHOULD come from the attack-motivation-ov open vocabulary.
        /// </summary>
        [JsonProperty("personal_motivations")]
        [BsonElement("personal_motivations")]
        public string? PersonalMotivations { get; set; }


        /*
         
         Embedded Relationships

created_by_ref

identifier (of type identity)

object_marking_refs

list of type identifier (of type marking-definition)

Common Relationships

duplicate-of, derived-from, related-to

Source

Relationship Type

Target

Description

threat-actor

attributed-to

identity

This Relationship describes that the Threat Actor's real identity is the related Identity.

 

For example, an attributed-to Relationship from the jay-sm17h Threat Actor to the John Smith Identity means that the actor known as jay-sm17h is John Smith.

threat-actor

compromises

infrastructure

This Relationship describes that the Threat Actor compromises the related Infrastructure.

threat-actor

hosts, owns

infrastructure

This Relationship describes that the Threat Actor hosts or owns the related Infrastructure (e.g. an actor that rents botnets to other threat actors).

threat-actor

impersonates

identity

This Relationship describes that the Threat Actor impersonates the related Identity.

 

For example, an impersonates Relationship from the gh0st Threat Actor to the ACME Corp. Identity means that the actor known as gh0st impersonates ACME Corp.

threat-actor

located-at

location

This Relationship describes that the Threat Actor is located at or in the related Location.

 

For example, a located-at relationship from the gh0st Threat Actor to a Location representing the United States means that ACME Corporation is located in the United States.

threat-actor

targets

identity, location, vulnerability

This Relationship describes that the Threat Actor uses exploits of the related Vulnerability or targets the type of victims described by the related Identity or Location.

 

For example, a targets Relationship from the jay-sm17h Threat Actor to a Vulnerability in a blogging platform indicates that attacks performed by John Smith often exploit that Vulnerability.

 

Similarly, a targets Relationship from the jay-sm17h Threat Actor to an Identity describing the energy sector in the United States means that John Smith often carries out attacks against targets in that sector.

threat-actor

uses

attack-pattern, infrastructure, malware, tool

This Relationship describes that attacks carried out as part of the Threat Actor typically use the related Attack Pattern, Infrastructure,  Malware, or Tool.

 

For example, a uses Relationship from the jay-sm17h Threat Actor to the xInject Malware indicates that xInject is often used by John Smith.

 

A campaign, threat actor, intrusion set, malware, or tool takes infrastructure and compromises and/or uses it for their own.

Reverse Relationships

campaign, intrusion-set

attributed-to

threat-actor

See forward relationship for definition.

malware

authored-by

threat-actor

See forward relationship for definition.

indicator

indicates

threat-actor

See forward relationship for definition.
         
         */
    }
}

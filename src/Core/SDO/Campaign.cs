using Cti.Stix.Core.SRO;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// A Campaign is a grouping of adversarial behaviors that describes a set of malicious activities or attacks (sometimes called waves) that occur 
    /// over a period of time against a specific set of targets. Campaigns usually have well defined objectives and may be part of an Intrusion Set.
    /// 
    /// Campaigns are often attributed to an intrusion set and threat actors. The threat actors may reuse known infrastructure from the intrusion set 
    /// or may set up new infrastructure specific for conducting that campaign.
    /// 
    /// Campaigns can be characterized by their objectives and the incidents they cause, people or resources they target, and the resources 
    /// (infrastructure, intelligence, Malware, Tools, etc.) they use.
    /// 
    /// For example, a Campaign could be used to describe a crime syndicate's attack using a specific variant of malware and new C2 servers against the 
    /// executives of ACME Bank during the summer of 2016 in order to gain secret information about an upcoming merger with another bank.
    /// </summary>
    public class Campaign : SdoStix
    {
        public Campaign()
        {
            ObjectType = "campaign";
        }

        /// <summary>
        /// A name used to identify the Campaign.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Campaign, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Alternative names used to identify this Campaign
        /// </summary>
        [JsonProperty("aliases")]
        [BsonElement("aliases")]
        public List<string>? Aliases { get; set; }

        /// <summary>
        /// The time that this Campaign was first seen.
        /// A summary property of data from sightings and other data that may or may not be available in STIX.If new sightings are received that are earlier 
        /// than the first seen timestamp, the object may be updated to account for the new data.
        /// </summary>
        [JsonProperty("first_seen")]
        [BsonElement("first_seen")]
        public DateTime? FirstSeen { get; set; }

        /// <summary>
        /// The time that this Campaign was last seen.
        /// A summary property of data from sightings and other data that may or may not be available in STIX.If new sightings are received that are later than the last 
        /// seen timestamp, the object may be updated to account for the new data.
        /// If this property and the first_seen property are both defined, then this property MUST be greater than or equal to the timestamp in the first_seen property.
        /// </summary>
        [JsonProperty("last_seen")]
        [BsonElement("last_seen")]
        public DateTime? LastSeen { get; set; }

        /// <summary>
        /// The Campaign’s primary goal, objective, desired outcome, or intended effect — what the Threat Actor or Intrusion Set hopes to accomplish with this Campaign.
        /// </summary>
        [JsonProperty("objective")]
        [BsonElement("objective")]
        public string? Objective { get; set; }

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

campaign

attributed-to

intrusion-set, threat-actor

This Relationship describes that the Intrusion Set or Threat Actor that is involved in carrying out the Campaign.

 

For example, an attributed-to Relationship from the Glass Gazelle Campaign to the Urban Fowl Threat Actor means that the actor carried out or was involved in some of the activity described by the Campaign.

campaign

compromises

infrastructure

This Relationship describes that the Campaign compromises the related Infrastructure.

campaign

originates-from

location

This Relationship describes that the Campaign originates from the related Location.

 

For example, an originates-from relationship from the Glass Gazelle Campaign to a Location representing North America means that Glass Gazelle appears to originate from or is located in North America.

campaign

targets

identity, location, vulnerability

This Relationship describes that the Campaign uses exploits of the related Vulnerability or targets the type of victims described by the related Identity or Location.

 

For example, a targets Relationship from the Glass Gazelle Campaign to a Vulnerability in a blogging platform indicates that attacks performed as part of Glass Gazelle often exploit that Vulnerability.

 

Similarly, a targets Relationship from the Glass Gazelle Campaign to an Identity describing the energy sector in the United States means that the Campaign typically carries out attacks against targets in that sector.

campaign

uses

attack-pattern, infrastructure, malware, tool

This Relationship describes that attacks carried out as part of the Campaign typically use the related Attack Pattern, Infrastructure, Malware, or Tool.

 

For example, a uses Relationship from the Glass Gazelle Campaign to the xInject Malware indicates that xInject is often used during attacks attributed to that Campaign.

 

A campaign, threat actor, intrusion set, malware, or tool takes infrastructure and compromises and/or uses it for their own.

Reverse Relationships

indicator

indicates

campaign

See forward relationship for definition.
         
         */
    }
}

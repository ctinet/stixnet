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
        public Campaign(string objectType = "campaign")
        {
            ObjectType = objectType;
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
    }
}

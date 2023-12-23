using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The IPv6 Address object represents one or more IPv6 addresses expressed using CIDR notation.
    /// </summary>
    public class Ipv6 : ScoStix
    {
        public Ipv6() { ObjectType = "ipv6-addr"; }

        /// <summary>
        /// Specifies the values of one or more IPv6 addresses expressed using CIDR notation.
        /// If a given IPv6 Address object represents a single IPv6 address, the CIDR /128 suffix MAY be omitted.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("value")]
        [BsonElement("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Specifies a list of references to one or more Layer 2 Media Access Control (MAC) addresses that the IPv6 address resolves to.
        /// The objects referenced in this list MUST be of type mac-addr.
        /// </summary>
        [JsonProperty("resolves_to_refs")]
        [BsonElement("resolves_to_refs")]
        public List<string>? ResolvesToRefs { get; set; }

        /// <summary>
        /// Specifies a list of references to one or more autonomous systems (AS) that the IPv6 address belongs to.
        /// The objects referenced in this list MUST be of type autonomous-system.
        /// </summary>
        [JsonProperty("belongs_to_refs")]
        [BsonElement("belongs_to_refs")]
        public List<string>? BelongsToRefs { get; set; }

        /*
         Source

Relationship Type

Target

Description

ipv6-addr

resolves-to

mac-addr

This Relationship describes that this IPv6 Address resolves to one or more Layer 2 Media Access Control (MAC) addresses.

ipv6-addr

belongs-to

autonomous-system

This Relationship describes that this IPv6 Address belongs to one or more autonomous systems (AS).
         
         */
    }
}

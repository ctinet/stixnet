using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The Domain Name object represents the properties of a network domain name.
    /// </summary>
    public class DomainName : ScoStix
    {
        public DomainName() { ObjectType = "domain-name"; }

        /// <summary>
        /// Specifies the value of the domain name. The value of this property MUST conform to [RFC1034], and each domain 
        /// and sub-domain contained within the domain name MUST conform to [RFC5890].
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("value")]
        [BsonElement("value")]
        public string Value { get; set; }

        /// <summary>
        /// Specifies a list of references to one or more IP addresses or domain names that the domain name resolves to.
        /// The objects referenced in this list MUST be of type ipv4-addr or ipv6-addr or domain-name (for cases such as CNAME records).
        /// </summary>
        [JsonProperty("resolves_to_refs")]
        [BsonElement("resolves_to_refs")]
        public List<string>? ResolvesToRefs { get; set; }

        /*
         Source

Relationship Type

Target

Description

domain-name

resolves-to

domain-name, ipv4-addr, ipv6-addr

This Relationship describes that this Domain Name resolves to one or more IP addresses or domain names.
         
         */
    }
}

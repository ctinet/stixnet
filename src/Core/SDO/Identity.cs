using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// Identities can represent actual individuals, organizations, or groups (e.g., ACME, Inc.) as well as classes of individuals, 
    /// organizations, systems or groups (e.g., the finance sector).
    /// </summary>
    public class Identity : SdoStix
    {
        public Identity(string objectType = "identity") { ObjectType = objectType; }

        /// <summary>
        /// The name of this Identity. When referring to a specific entity (e.g., an individual or organization), 
        /// this property SHOULD contain the canonical name of the specific entity.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Identity, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The list of roles that this Identity performs (e.g., CEO, Domain Administrators, Doctors, Hospital, or Retailer). 
        /// No open vocabulary is yet defined for this property.
        /// </summary>
        [JsonProperty("roles")]
        [BsonElement("roles")]
        public List<string>? Roles { get; set; }

        /// <summary>
        /// The type of entity that this Identity describes, e.g., an individual or organization.
        /// </summary>
        [JsonProperty("identity_class")]
        [BsonElement("identity_class")]
        public string? IdentityClass { get; set; }

        /// <summary>
        /// The list of industry sectors that this Identity belongs to.
        /// </summary>
        [JsonProperty("sectors")]
        [BsonElement("sectors")]
        public List<string>? Sectors { get; set; }

        /// <summary>
        /// The contact information (e-mail, phone number, etc.) for this Identity. No format for this information is currently defined by this specification.
        /// </summary>
        [JsonProperty("contact_information")]
        [BsonElement("contact_information")]
        public string? ContactInformation { get; set; }

        /*
         
        Embedded Relationships:         created_by_ref          identifier (of type identity)
                                        object_marking_refs     list of type identifier (of type marking-definition)
        
        Common Relationships:           duplicate-of, derived-from, related-to
        
        Source                  Relationship Type           Target              Description
        ------------------------------------------------------------------------------------------------------------------------------------------------------------------
        identity                located-at                  location            This Relationship describes that the Identity is located at or in the related Location.
                                                                                For example, a located-at relationship from the ACME Corporation to a Location 
                                                                                representing the United States means that ACME Corporation is located in the United States.
        
        Reverse Relationships
        
        Source                  Relationship Type           Target              Description
        ------------------------------------------------------------------------------------------------------------------------------------------------------------------
        attack-pattern,         targets                     identity            See forward relationship for definition.
        campaign,
        intrusion-set,
        malware,  
        threat-actor,
        tool
        
        threat-actor            attributed-to,              identity            See forward relationship for definition.
                                impersonates
         
         */
    }
}

using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// A Location represents a geographic location. The location may be described as any, some or all of the following: 
    /// region (e.g., North America), civic address (e.g. New York, US), latitude and longitude.
    /// 
    /// At least one of the following properties/sets of properties MUST be provided:
    ///     - region
    ///     - country
    ///     - latitude and longitude
    /// </summary>
    public class Location : SdoStix
    {
        public Location() { ObjectType = "Location"; }

        /// <summary>
        /// A name used to identify the Location.
        /// </summary>
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A textual description of the Location.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The latitude of the Location in decimal degrees. Positive numbers describe latitudes north of the equator, and negative 
        /// numbers describe latitudes south of the equator. The value of this property MUST be between -90.0 and 90.0, inclusive.
        /// </summary>
        [JsonProperty("latitude")]
        [BsonElement("latitude")]
        public float? Latitude { get; set; }

        /// <summary>
        /// The longitude of the Location in decimal degrees. Positive numbers describe longitudes east of the prime meridian and 
        /// negative numbers describe longitudes west of the prime meridian. The value of this property MUST be between -180.0 and 180.0, inclusive.
        /// </summary>
        [JsonProperty("longitude")]
        [BsonElement("longitude")]
        public float? Longitude { get; set; }

        /// <summary>
        /// Defines the precision of the coordinates specified by the latitude and longitude properties. This is measured in meters. 
        /// The actual Location may be anywhere up to precision meters from the defined point.
        /// </summary>
        [JsonProperty("precision")]
        [BsonElement("precision")]
        public float? Precision { get; set; }

        /// <summary>
        /// The region that this Location describes.
        /// </summary>
        [JsonProperty("region")]
        [BsonElement("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The country that this Location describes
        /// This property SHOULD contain a valid ISO 3166-1 ALPHA-2 Code
        /// </summary>
        [JsonProperty("country")]
        [BsonElement("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The state, province, or other sub-national administrative area that this Location describes.
        /// This property SHOULD contain a valid ISO 3166-2 Code
        /// </summary>
        [JsonProperty("administrative_area")]
        [BsonElement("administrative_area")]
        public string? AdministrativeArea { get; set; }

        /// <summary>
        /// The city that this Location describes.
        /// </summary>
        [JsonProperty("city")]
        [BsonElement("city")]
        public string? City { get; set; }

        /// <summary>
        /// The street address that this Location describes. This property includes all aspects or parts of the street address. 
        /// For example, some addresses may have multiple lines including a mailstop or apartment number.
        /// </summary>
        [JsonProperty("street_address")]
        [BsonElement("street_address")]
        public string? StreetAddress { get; set; }

        /// <summary>
        /// The postal code for this Location.
        /// </summary>
        [JsonProperty("postal_code")]
        [BsonElement("postal_code")]
        public string? PostalCode { get; set; }


        /*
         
        Embedded Relationships:         created_by_ref                  identifier (of type identity)
                                        object_marking_refs             list of type identifier (of type marking-definition)

        Common Relationships:           duplicate-of, derived-from, related-to

        Reverse Relationships:
        Source                                  Relationship Type            Target                         Description
        --------------------------------------------------------------------------------------------------------------------------------------------------------------------
        identity,                               located-at                  location                        See forward relationship for definition.
        infrastructure, 
        threat-actor

        campaign, intrusion-set, malware        originates-from             location                        See forward relationship for definition.

        attack-pattern, campaign,               targets                     location                        See forward relationship for definition.
        intrusion-set, malware,
        threat-actor, tool


         
         */
    }
}

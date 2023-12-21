using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// Observed Data conveys information about cyber security related entities such as files, systems, and networks using the STIX Cyber-observable Objects (SCOs). 
    /// For example, Observed Data can capture information about an IP address, a network connection, a file, or a registry key. Observed Data is not an intelligence 
    /// assertion, it is simply the raw information without any context for what it means.
    /// 
    /// Observed Data can capture that a piece of information was seen one or more times. Meaning, it can capture both a single observation of a single entity (file, network connection) 
    /// as well as the aggregation of multiple observations of an entity. When the number_observed property is 1 the Observed Data represents a single entity. 
    /// When the number_observed property is greater than 1, the Observed Data represents several instances of an entity potentially collected over a period of time. 
    /// If a time window is known, that can be captured using the first_observed and last_observed properties. When used to collect aggregate data, it is likely that 
    /// some properties in the SCO (e.g., timestamp properties) will be omitted because they would differ for each of the individual observations.
    /// </summary>
    public class ObservedData : SdoStix
    {
        public ObservedData(string objectType = "observed-data") { ObjectType = objectType; }

        /// <summary>
        /// The beginning of the time window during which the data was seen.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("first_observed")]
        [BsonElement("first_observed")]
        public DateTime FirstObserved { get; set; }

        /// <summary>
        /// The end of the time window during which the data was seen.
        /// This MUST be greater than or equal to the timestamp in the first_observed property.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("last_observed")]
        [BsonElement("last_observed")]
        public DateTime LastObserved { get; set; }

        /// <summary>
        /// The number of times that each Cyber-observable object represented in the objects or object_ref 
        /// property was seen. If present, this MUST be an integer between 1 and 999,999,999 inclusive.
        /// 
        /// If the number_observed property is greater than 1, the data contained in the objects or object_refs 
        /// property was seen multiple times. In these cases, object creators MAY omit properties of the 
        /// SCO (such as timestamps) that are specific to a single instance of that observed data.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("number_observed")]
        [BsonElement("number_observed")]
        public int NumberObserved { get; set; }

        /// <summary>
        /// (Deprecated), type: observable-container
        /// A dictionary of SCO representing the observation. The dictionary MUST contain at least one object.
        /// The cyber observable content MAY include multiple objects if those objects are related as part of 
        /// a single observation. Multiple objects not related to each other via cyber observable Relationships 
        /// MUST NOT be contained within the same Observed Data instance.
        /// This property MUST NOT be present if object_refs is provided.
        /// For example, a Network Traffic object and two IPv4 Address objects related via the src_ref and dst_ref 
        /// properties can be contained in the same Observed Data because they are all related and used to characterize 
        /// that single entity.
        /// NOTE: this property is now deprecated in favor of object_refs and will be removed in a future version.
        /// </summary>
        [Obsolete]
        [JsonProperty("objects")]
        [BsonElement("objects")]
        public object Objects { get; set; }

        /// <summary>
        /// A list of SCOs and SROs representing the observation. The object_refs MUST contain at least one SCO reference if defined.
        /// The object_refs MAY include multiple SCOs and their corresponding SROs, if those SCOs are related as part of a single observation.
        /// 
        /// For example, a Network Traffic object and two IPv4 Address objects related via the src_ref and dst_ref properties can be contained 
        /// in the same Observed Data because they are all related and used to characterize that single entity.
        /// 
        /// This property MUST NOT be present if objects is provided.
        /// </summary>
        [JsonProperty("object_refs")]
        [BsonElement("object_refs")]
        public List<string>? ObjectRefs { get; set; }

        /*
         
         Embedded Relationships

created_by_ref

identifier (of type identity)

object_marking_refs

list of type identifier (of type marking-definition)

object_refs

list of type identifier (of type SCO or SRO)

Common Relationships

duplicate-of, derived-from, related-to

Source

Name

Target

Description

—

—

—

—

Reverse Relationships

indicator

 

based-on

observed-data

See forward relationship for definition.

infrastructure

consists-of

observed-data

See forward relationship for definition
         
         
         */

    }
}

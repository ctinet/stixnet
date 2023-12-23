using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cti.Stix.Core.SRO
{
    /// <summary>
    /// A Sighting denotes the belief that something in CTI (e.g., an indicator, malware, tool, threat actor, etc.) was seen. Sightings are used 
    /// to track who and what are being targeted, how attacks are carried out, and to track trends in attack behavior.
    /// 
    /// The Sighting relationship object is a special type of SRO; it is a relationship that contains extra properties not present on the Generic 
    /// Relationship object. These extra properties are included to represent data specific to sighting relationships (e.g., count, representing 
    /// how many times something was seen), but for other purposes a Sighting can be thought of as a Relationship with a name of "sighting-of". 
    /// Sighting is captured as a relationship because you cannot have a sighting unless you have something that has been sighted. Sighting does 
    /// not make sense without the relationship to what was sighted.
    /// 
    /// Sighting relationships relate three aspects of the sighting:
    ///   -  What was sighted, such as the Indicator, Malware, Campaign, or other SDO (sighting_of_ref)
    ///   -  Who sighted it and/or where it was sighted, represented as an Identity (where_sighted_refs)
    ///   -  What was actually seen on systems and networks, represented as Observed Data (observed_data_refs)
    ///   
    /// What was sighted is required; a sighting does not make sense unless you say what you saw. Who sighted it, where it was sighted, and what 
    /// was actually seen are optional. In many cases it is not necessary to provide that level of detail in order to provide value.
    /// 
    /// Sightings are used whenever any SDO has been "seen". In some cases, the object creator wishes to convey very little information about the 
    /// sighting; the details might be sensitive, but the fact that they saw a malware instance or threat actor could still be very useful. 
    /// In other cases, providing the details may be helpful or even necessary; saying exactly which of the 1000 IP addresses in an indicator were 
    /// sighted is helpful when tracking which of those IPs is still malicious.
    /// 
    /// Sighting is distinct from Observed Data in that Sighting is an intelligence assertion ("I saw this threat actor") while Observed Data is 
    /// simply information ("I saw this file"). When you combine them by including the linked Observed Data (observed_data_refs) from a Sighting, 
    /// you can say "I saw this file, and that makes me think I saw this threat actor".
    /// </summary>
    public class Sighting : SroStix
    {
        public Sighting()
        {
            ObjectType = "sighting";
        }

        /// <summary>
        /// A description that provides more details and context about the Sighting.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The beginning of the time window during which the SDO referenced by the sighting_of_ref property was sighted.
        /// </summary>
        [JsonProperty("first_seen")]
        [BsonElement("first_seen")]
        public DateTime? FirstSeen { get; set; }

        /// <summary>
        /// The end of the time window during which the SDO referenced by the sighting_of_ref property was sighted.
        /// 
        /// If this property and the first_seen property are both defined, then this property MUST be greater than or equal to the timestamp 
        /// in the first_seen property.
        /// </summary>
        [JsonProperty("last_seen")]
        [BsonElement("last_seen")]
        public DateTime? LastSeen { get; set; }

        /// <summary>
        /// If present, this MUST be an integer between 0 and 999,999,999 inclusive and represents the number of times the SDO referenced by 
        /// the sighting_of_ref property was sighted.
        /// 
        /// Observed Data has a similar property called number_observed, which refers to the number of times the data was observed. These 
        /// counts refer to different concepts and are distinct.
        /// 
        /// For example, a single sighting of a DDoS bot might have many millions of observations of the network traffic that it generates.
        /// Thus, the Sighting count would be 1 (the bot was observed once) but the Observed Data number_observed would be much higher.
        /// 
        /// As another example, a sighting with a count of 0 can be used to express that an indicator was not seen at all.
        /// </summary>
        [JsonProperty("count")]
        [BsonElement("count")]
        public int? Count { get; set; }

        /// <summary>
        /// An ID reference to the SDO that was sighted (e.g., Indicator or Malware).
        /// For example, if this is a Sighting of an Indicator, that Indicator’s ID would be the value of this property.
        /// This property MUST reference only an SDO.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("sighting_of_ref")]
        [BsonElement("sighting_of_ref")]
        public string SightingOfRef { get; set; }

        /// <summary>
        /// A list of ID references to the Observed Data objects that contain the raw cyber data for this Sighting.
        /// For example, a Sighting of an Indicator with an IP address could include the Observed Data for the network connection that the 
        /// Indicator was used to detect.
        /// This property MUST reference only Observed Data SDOs.
        /// </summary>
        [JsonProperty("observed_data_refs")]
        [BsonElement("observed_data_refs")]
        public List<string>? ObservedDataRefs { get; set; }

        /// <summary>
        /// A list of ID references to the Identity or Location objects describing the entities or types of entities that saw the sighting.
        /// Omitting the where_sighted_refs property does not imply that the sighting was seen by the object creator. To indicate that the 
        /// sighting was seen by the object creator, an Identity representing the object creator should be listed in where_sighted_refs.
        /// 
        /// This property MUST reference only Identity or Location SDOs.
        /// </summary>
        [JsonProperty("where_sighted_refs")]
        [BsonElement("where_sighted_refs")]
        public List<string>? WhereSightedRefs { get; set; }

        /// <summary>
        /// The summary property indicates whether the Sighting should be considered summary data. Summary data is an aggregation of previous 
        /// Sightings reports and should not be considered primary source data. Default value is false.
        /// </summary>
        [JsonProperty("summary")]
        [BsonElement("summary")]
        public bool? Summary { get; set; }

    }
}

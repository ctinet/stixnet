using Newtonsoft.Json;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix
{
    /// <summary>
    /// A Bundle is a collection of arbitrary STIX Objects grouped together in a single container
    /// </summary>
    public interface IStixBundle : IStix
    {
        /// <summary>
        /// Specifies a set of one or more STIX Objects
        /// </summary>
        public List<IStix> Objects { get; set; }
    }

    /// <summary>
    /// A Bundle is a collection of arbitrary STIX Objects grouped together in a single container. A Bundle does not have any semantic meaning and 
    /// the objects contained within the Bundle are not considered related by virtue of being in the same Bundle.
    /// 
    /// A STIX Bundle Object is not a STIX Object but makes use of the type and id Common Properties. A Bundle is transient, and implementations SHOULD 
    /// NOT assume that other implementations will treat it as a persistent object or keep any custom properties found on the bundle itself.
    /// 
    /// The JSON MTI serialization uses the JSON Object type [RFC8259] when representing bundle.
    /// </summary>
    public class Bundle : IStixBundle
    {
        public Bundle()
        {
            ObjectType = "bundle";
        }

        /// <summary>
        /// The type property identifies the type of object. The value of this property MUST be bundle.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("type")]
        [BsonElement("type")]
        public virtual string ObjectType { get; set; } = string.Empty;

        /// <summary>
        /// An identifier for this Bundle. The id property for the Bundle is designed to help tools that may need it for processing, 
        /// however, tools are not required to store or track it. Tools that consume STIX should not rely on the ability to refer 
        /// to bundles by ID.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("id")]
        [BsonElement("id")]
        public virtual string ID { get; set; } = string.Empty;

        /// <summary>
        /// Specifies a set of one or more STIX Objects. Objects in this list MUST be a STIX Object.
        /// </summary>
        [JsonProperty("objects")]
        [BsonElement("objects")]
        public virtual List<IStix> Objects { get; set; }
    }
}

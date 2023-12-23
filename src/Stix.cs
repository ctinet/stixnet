using Cti.Stix.Types;
using Newtonsoft.Json;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix
{
    /// <summary>
    /// Structured Threat Information Expression
    /// </summary>
    public interface IStix
    {
        /// <summary>
        /// The type property identifies the type of STIX Object
        /// </summary>
        public string ObjectType { get; set; }

        /// <summary>
        /// The id property uniquely identifies this object.
        /// </summary>
        public string ID { get; set; }

    }

    /// <summary>
    /// STIX is a schema that defines a taxonomy of cyber threat intelligence
    /// </summary>
    public abstract class Stix : IStix
    {
        /// <summary>
        /// Raw is excluded from JSON and BSON serialization
        /// </summary>
        [JsonIgnore]
        [BsonIgnore]
        public virtual byte[] Raw { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// The type property identifies the type of STIX Object
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("type")]
        [BsonElement("type")]
        public virtual string ObjectType { get; set; } = string.Empty;

        /// <summary>
        /// The id property uniquely identifies this object.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("id")]
        [BsonElement("id")]
        public virtual string ID { get; set; } = string.Empty;
        
    }
}

using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The Mutex object represents the properties of a mutual exclusion (mutex) object.
    /// </summary>
    public class Mutex : ScoStix
    {
        public Mutex()
        {
            ObjectType = "mutex";
        }

        /// <summary>
        /// Specifies the name of the mutex object.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }
    }
}

using Cti.Stix.Types;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cti.Stix.Core
{
    public interface IScoStix : IStix
    {
        public List<string> ObjectMarkingRefs { get; set; }

        public List<GranularMarking> GranularMarkings { get; set; }

        public Dictionary<string, byte[]> Extensions { get; set; }

        public bool? Defanged { get; set; }
    }

    public class ScoStix : Stix, IScoStix, IStixSpecVersion
    {
        /// <summary>
        /// The version of the STIX specification used to represent this object.
        /// </summary>
        [JsonProperty("spec_version")]
        [BsonElement("spec_version")]
        public string? SpecVersion { get; set; } = default;

        /// <summary>
        /// The object_marking_refs property specifies a list of id properties of marking-definition objects that apply to this object.
        /// </summary>
        [JsonProperty("object_marking_refs")]
        [BsonElement("object_marking_refs")]
        public List<string>? ObjectMarkingRefs { get; set; } = default;

        /// <summary>
        /// The granular_markings property specifies a list of granular markings applied to this object.
        /// </summary>
        [JsonProperty("granular_markings")]
        [BsonElement("granular_markings")]
        public List<GranularMarking>? GranularMarkings { get; set; } = default;

        [JsonProperty("extensions")]
        [BsonElement("extensions")]
        public Dictionary<string, byte[]>? Extensions { get; set; } = default;

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("defanged")]
        [BsonElement("defanged")]
        public bool? Defanged { get; set; }
    }
}

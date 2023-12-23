using Cti.Stix.Types;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cti.Stix.Core
{
    /// <summary>
    /// STIX Cyber-observable Objects
    /// </summary>
    public interface IScoStix : IStix
    {
        public string? SpecVersion { get; set; }
        public List<string> ObjectMarkingRefs { get; set; }

        public List<GranularMarking> GranularMarkings { get; set; }

        public Dictionary<string, byte[]> Extensions { get; set; }

        public bool? Defanged { get; set; }
    }

    /// <summary>
    /// STIX Cyber-observable Objects
    /// Objects that represent observed facts about a network or host that may be used and related to higher level intelligence to form 
    /// a more complete understanding of the threat landscape.
    /// 
    /// STIX Cyber-observable Objects (SCOs) document the facts concerning what happened on a network or host, and do not capture the who, 
    /// when, or why. By associating SCOs with STIX Domain Objects (SDOs), it is possible to convey a higher-level understanding of the 
    /// threat landscape, and to potentially provide insight as to the who and the why particular intelligence may be relevant to an organization. 
    /// For example, information about a file that existed, a process that was observed running, or that network traffic occurred between two IPs 
    /// can all be captured as SCOs.
    /// </summary>
    public abstract class ScoStix : Stix, IScoStix
    {
        /// <summary>
        /// The version of the STIX specification used to represent this object.
        /// </summary>
        [JsonProperty("spec_version")]
        [BsonElement("spec_version")]
        public virtual string? SpecVersion { get; set; } = default;

        /// <summary>
        /// The object_marking_refs property specifies a list of id properties of marking-definition objects that apply to this object.
        /// </summary>
        [JsonProperty("object_marking_refs")]
        [BsonElement("object_marking_refs")]
        public virtual List<string>? ObjectMarkingRefs { get; set; } = default;

        /// <summary>
        /// The granular_markings property specifies a list of granular markings applied to this object.
        /// </summary>
        [JsonProperty("granular_markings")]
        [BsonElement("granular_markings")]
        public virtual List<GranularMarking>? GranularMarkings { get; set; } = default;

        [JsonProperty("extensions")]
        [BsonElement("extensions")]
        public virtual Dictionary<string, byte[]>? Extensions { get; set; } = default;

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("defanged")]
        [BsonElement("defanged")]
        public virtual bool? Defanged { get; set; }
    }
}

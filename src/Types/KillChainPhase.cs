using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Cti.Stix.Types
{
    /// <summary>
    /// The kill-chain-phase represents a phase in a kill chain, which describes the various phases an 
    /// attacker may undertake in order to achieve their objectives.
    /// </summary>
    public class KillChainPhase
    {
        /// <summary>
        /// The name of the kill chain. The value of this property SHOULD be all lowercase and SHOULD 
        /// use hyphens instead of spaces or underscores as word separators.
        /// </summary>
        [JsonProperty("kill_chain_name")]
        [BsonElement("kill_chain_name")]
        public string KillChainName { get; set; }

        /// <summary>
        /// The name of the phase in the kill chain. The value of this property SHOULD be all lowercase 
        /// and SHOULD use hyphens instead of spaces or underscores as word separators.
        /// </summary>
        [JsonProperty("phase_name")]
        [BsonElement("phase_name")]
        public string PhaseName { get; set; }

    }
}

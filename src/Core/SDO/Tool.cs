using Cti.Stix.Types;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /*
     
name (String, required)
description (String)
tool_types (List of Open Vocabs)
aliases (List of Strings)
kill_chain_phases (List of Kill Chain Phases)
tool_version (String)
     */

    /// <summary>
    /// Tools are legitimate software that can be used by threat actors to perform attacks. Knowing how and when threat actors use such tools can be 
    /// important for understanding how campaigns are executed. Unlike malware, these tools or software packages are often found on a system and have 
    /// legitimate purposes for power users, system administrators, network administrators, or even normal users. Remote access tools (e.g., RDP) and 
    /// network scanning tools (e.g., Nmap) are examples of Tools that may be used by a Threat Actor during an attack.
    /// 
    /// The Tool SDO characterizes the properties of these software tools and can be used as a basis for making an assertion about how a Threat Actor 
    /// uses them during an attack. It contains properties to name and describe the tool, a list of Kill Chain Phases the tool can be used to carry 
    /// out, and the version of the tool.
    /// 
    /// This SDO MUST NOT be used to characterize malware. Further, Tool MUST NOT be used to characterize tools used as part of a course of action in 
    /// response to an attack.
    /// </summary>
    public class Tool : SdoStix
    {
        public Tool() { ObjectType = "tool"; }

        /// <summary>
        /// The name used to identify the Tool.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Tool, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The kind(s) of tool(s) being described.
        /// The values for this property SHOULD come from the tool-type-ov open vocabulary.
        /// </summary>
        [JsonProperty("tool_types")]
        [BsonElement("tool_types")]
        public List<string>? ToolTypes { get; set; }

        /// <summary>
        /// Alternative names used to identify this Tool.
        /// </summary>
        [JsonProperty("aliases")]
        [BsonElement("aliases")]
        public List<string>? Aliases { get; set; }

        /// <summary>
        /// The list of kill chain phases for which this Tool can be used.
        /// </summary>
        [JsonProperty("kill_chain_phases")]
        [BsonElement("kill_chain_phases")]
        public List<KillChainPhase>? KillChainPhases { get; set; }

        /// <summary>
        /// The version identifier associated with the Tool.
        /// </summary>
        [JsonProperty("tool_version")]
        [BsonElement("tool_version")]
        public string? ToolVersion { get; set; }

        /*
         
         Embedded Relationships

created_by_ref

identifier (of type identity)

object_marking_refs

list of type identifier (of type marking-definition)

Common Relationships

duplicate-of, derived-from, related-to

Source

Relationship Type

Target

Description

tool

delivers

malware

This Relationship describes that this Tool is used to deliver a malware instance (or family).

tool

drops

malware

This Relationship documents that this Tool drops a malware instance (or family).

tool

has

vulnerability

This Relationship describes that this specific Tool has this specific Vulnerability.

 

For example, a tool may not have been patched and currently is impacted by a CVE.

tool

targets

identity, infrastructure, location, vulnerability

This Relationship documents that this Tool is being used to target this Identity, Infrastructure, Location, or exploit the Vulnerability.

 

For example, a targets Relationship linking an exploit Tool to a Vulnerability for CVE-2016-0001 means that the tool exploits that vulnerability.

 

Similarly, a targets Relationship linking a DDoS Tool to an Identity representing the energy sector means that Tool is typically used against targets in the energy sector.

tool

uses

infrastructure

This Relationship describes that this Tool uses the related Infrastructure.

Reverse Relationships

infrastructure

hosts

tool

See forward relationship for definition

malware

downloads, drops

tool

See forward relationship for definition

indicator

indicates

tool

See forward relationship for definition

course-of-action

mitigates

tool

See forward relationship for definition

attack-pattern, campaign, intrusion-set, malware,

threat-actor

uses

tool

See forward relationship for definition
         
         */

    }
}

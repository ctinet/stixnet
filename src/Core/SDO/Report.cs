using Cti.Stix.Core.SCO;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /// <summary>
    /// Reports are collections of threat intelligence focused on one or more topics, such as a description of a threat actor, 
    /// malware, or attack technique, including context and related details. They are used to group related threat intelligence 
    /// together so that it can be published as a comprehensive cyber threat story.
    /// </summary>
    public class Report : SdoStix
    {
        public Report() { ObjectType = "report"; }

        /// <summary>
        /// A name used to identify the Report.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description that provides more details and context about the Report, potentially including its purpose and its key characteristics.
        /// </summary>
        [JsonProperty("description")]
        [BsonElement("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The primary type(s) of content found in this report.
        /// 
        /// The values for this property SHOULD come from the report-type-ov open vocabulary.
        /// </summary>
        [JsonProperty("report_types")]
        [BsonElement("report_types")]
        public List<string>? ReportTypes { get; set; }

        /// <summary>
        /// The date that this Report object was officially published by the creator of this report.
        /// The publication date(public release, legal release, etc.) may be different than the date the report was created 
        /// or shared internally(the date in the created property).
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("published")]
        [BsonElement("published")]
        public DateTime Published { get; set; }

        /// <summary>
        /// Specifies the STIX Objects that are referred to by this Report.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
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

list of type identifier (of STIX Objects type)

Common Relationships

duplicate-of, derived-from, related-to
         
         */

    }
}

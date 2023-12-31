﻿using Cti.Stix.Types;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cti.Stix.Core
{
    /// <summary>
    /// STIX Relationship Objects
    /// </summary>
    public interface ISroStix : IStix
    {
        public string? SpecVersion { get; set; }

        public string CreatedByRef { get; set; }

        public string Created { get; set; }

        public string Modified { get; set; }

        public bool Revoked { get; set; }

        public List<string> Labels { get; set; }

        public int Confidence { get; set; }

        public string Lang { get; set; }

        public List<ExternalReference> ExternalReferences { get; set; }

        public List<string> ObjectMarkingRefs { get; set; }

        public List<GranularMarking> GranularMarkings { get; set; }

        public Dictionary<string, byte[]> Extensions { get; set; }
    }


    /// <summary>
    /// STIX Relationship Objects:
    /// Objects that connect STIX Domain Objects together, STIX Cyber-observable Objects together, and connect STIX Domain Objects 
    /// and STIX Cyber-observable Objects together to form a more complete understanding of the threat landscape.
    /// </summary>
    public abstract class SroStix : Stix, ISroStix
    {
        /// <summary>
        /// The version of the STIX specification used to represent this object.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("spec_version")]
        [BsonElement("spec_version")]
        public virtual string SpecVersion { get; set; }

        /// <summary>
        /// The created_by_ref property specifies the id property of the identity object that describes the entity that created this object.
        /// </summary>
        [JsonProperty("created_by_ref")]
        [BsonElement("created_by_ref")]
        public virtual string CreatedByRef { get; set; }

        /// <summary>
        /// The created property represents the time at which the object was originally created.
        /// </summary>
        [JsonProperty("created")]
        [BsonElement("created")]
        public virtual string Created { get; set; }

        /// <summary>
        /// The modified property is only used by STIX Objects that support versioning and represents the time that this particular version 
        /// of the object was last modified.
        /// </summary>
        [JsonProperty("modified")]
        [BsonElement("modified")]
        public virtual string Modified { get; set; }

        /// <summary>
        /// The revoked property is only used by STIX Objects that support versioning and indicates whether the object has been revoked.
        /// </summary>
        [JsonProperty("revoked")]
        [BsonElement("revoked")]
        public virtual bool Revoked { get; set; }

        /// <summary>
        /// The labels property specifies a set of terms used to describe this object. The terms are user-defined or trust-group defined and 
        /// their meaning is outside the scope of this specification and MAY be ignored.
        /// </summary>
        [JsonProperty("labels")]
        [BsonElement("labels")]
        public virtual List<string> Labels { get; set; }

        /// <summary>
        /// The confidence property identifies the confidence that the creator has in the correctness of their data. The confidence value MUST
        /// be a number in the range of 0-100.
        /// </summary>
        [JsonProperty("confidence")]
        [BsonElement("confidence")]
        public virtual int Confidence { get; set; }

        /// <summary>
        /// The lang property identifies the language of the text content in this object. When present, it MUST be a language code conformant 
        /// to [RFC5646]. If the property is not present, then the language of the content is en (English).
        /// </summary>
        [JsonProperty("lang")]
        [BsonElement("lang")]
        public virtual string Lang { get; set; }

        /// <summary>
        /// The external_references property specifies a list of external references which refers to non-STIX information. This property is 
        /// used to provide one or more URLs, descriptions, or IDs to records in other systems.
        /// </summary>
        [JsonProperty("external_references")]
        [BsonElement("external_references")]
        public virtual List<ExternalReference> ExternalReferences { get; set; }

        /// <summary>
        /// The object_marking_refs property specifies a list of id properties of marking-definition objects that apply to this object.
        /// </summary>
        [JsonProperty("object_marking_refs")]
        [BsonElement("object_marking_refs")]
        public virtual List<string> ObjectMarkingRefs { get; set; }

        /// <summary>
        /// The granular_markings property specifies a list of granular markings applied to this object.
        /// </summary>
        [JsonProperty("granular_markings")]
        [BsonElement("granular_markings")]
        public virtual List<GranularMarking> GranularMarkings { get; set; }

        /// <summary>
        /// Specifies any extensions of the object, as a dictionary.
        /// 
        /// Dictionary keys SHOULD be the id of a STIX Extension object or the name of a predefined object extension found in this specification, 
        /// depending on the type of extension being used.
        /// </summary>
        [JsonProperty("extensions")]
        [BsonElement("extensions")]
        public virtual Dictionary<string, byte[]> Extensions { get; set; }
    }
}

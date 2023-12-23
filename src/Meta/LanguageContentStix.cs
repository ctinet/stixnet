using Cti.Stix.Types;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cti.Stix.Meta
{
    /// <summary>
    /// The Language Content object represents text content for STIX Objects represented in languages other than that of the original object. 
    /// Language content may be a translation of the original object by a third-party, a first-source translation by the original publisher, 
    /// or additional official language content provided at the time of creation.
    /// 
    /// Language Content contains two important sets of properties:
    ///     - The object_ref and object_modified properties specify the target object that the language content applies to.
    ///         For example, to provide additional language content for a Campaign, the object_ref property should be set to the id of the 
    ///         Campaign and the object_modified property set to its modified time. Most relationships in STIX are not specific to a particular 
    ///         version of a STIX object, but because language content provides the translation of specific text, the object_modified property 
    ///         is necessary to provide that specificity.
    ///     - The content property is a dictionary which maps to properties in the target object in order to provide a translation of them.
    /// </summary>
    public class LanguageContentStix : Stix, IStix
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
        /// The created property represents the time at which the object was originally created.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("created")]
        [BsonElement("created")]
        public virtual DateTime Created { get; set; }

        /// <summary>
        /// The modified property is only used by STIX Objects that support versioning and represents the time that this particular version 
        /// of the object was last modified.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("modified")]
        [BsonElement("modified")]
        public virtual DateTime Modified { get; set; }

        /// <summary>
        /// The created_by_ref property specifies the id property of the identity object that describes the entity that created this object.
        /// 
        /// related-to
        /// </summary>
        [JsonProperty("created_by_ref")]
        [BsonElement("created_by_ref")]
        public virtual string? CreatedByRef { get; set; } = default;

        /// <summary>
        /// The revoked property is only used by STIX Objects that support versioning and indicates whether the object has been revoked.
        /// </summary>
        [JsonProperty("revoked")]
        [BsonElement("revoked")]
        public virtual bool? Revoked { get; set; } = default;

        /// <summary>
        /// The labels property specifies a set of terms used to describe this object. The terms are user-defined or trust-group defined and 
        /// their meaning is outside the scope of this specification and MAY be ignored.
        /// </summary>
        [JsonProperty("labels")]
        [BsonElement("labels")]
        public virtual List<string>? Labels { get; set; } = null;

        /// <summary>
        /// The confidence property identifies the confidence that the creator has in the correctness of their data. The confidence value MUST
        /// be a number in the range of 0-100.
        /// </summary>
        [JsonProperty("confidence")]
        [BsonElement("confidence")]
        public virtual int? Confidence { get; set; } = default;

        /// <summary>
        /// The external_references property specifies a list of external references which refers to non-STIX information. This property is 
        /// used to provide one or more URLs, descriptions, or IDs to records in other systems.
        /// </summary>
        [JsonProperty("external_references")]
        [BsonElement("external_references")]
        public virtual List<ExternalReference>? ExternalReferences { get; set; } = default;

        /// <summary>
        /// The object_marking_refs property specifies a list of id properties of marking-definition objects that apply to this object.
        /// 
        /// related-to
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

        /// <summary>
        /// Specifies any extensions of the object, as a dictionary.
        /// Dictionary keys SHOULD be the id of a STIX Extension object or the name of a predefined object extension found in this specification, 
        /// depending on the type of extension being used.
        /// </summary>
        [JsonProperty("extensions")]
        [BsonElement("extensions")]
        public Dictionary<string, byte[]>? Extensions { get; set; } = default;

        /// <summary>
        /// The object_ref property identifies the id of the object that this Language Content applies to. It MUST be the identifier for a STIX Object.
        /// </summary>
        [JsonProperty("object_ref")]
        [BsonElement("object_ref")]
        public string? ObjectRef { get; set; }

        /// <summary>
        /// The object_modified property identifies the modified time of the object that this Language Content applies to. It MUST be an exact match for 
        /// the modified time of the STIX Object being referenced.
        /// </summary>
        [JsonProperty("object_modified")]
        [BsonElement("object_modified")]
        public DateTime? ObjectModified { get; set; }

        /// <summary>
        /// The contents property contains the actual Language Content (translation).
        /// 
        /// The keys in the dictionary MUST be RFC 5646 language codes for which language content is being provided [RFC5646]. The values each consist of 
        /// a dictionary that mirrors the properties in the target object (identified by object_ref and object_modified). For example, to provide a 
        /// translation of the name property on the target object the key in the dictionary would be name.
        /// 
        /// For each key in the nested dictionary:
        ///     - If the original property is a string, the corresponding property in the language content object MUST contain a string with the content for that 
        ///       property in the language of the top-level key.
        ///     - If the original property is a list, the corresponding property in the translation object must also be a list. Each item in this list recursively 
        ///       maps to the item at the same position in the list contained in the target object. The lists MUST have the same length.
        ///     - In the event that translations are only provided for some list items, the untranslated list items MUST be represented by an empty string (""). 
        ///       This indicates to a consumer of the Language Content object that they should interpolate the translated list items in the Language Content 
        ///       object with the corresponding (untranslated) list items from the original object as indicated by the object_ref property.
        ///     - If the original property is an object (including dictionaries), the corresponding location in the translation object must also be an object. 
        ///       Each key/value field in this object recursively maps to the object with the same key in the original.
        /// 
        /// The translation object MAY contain only a subset of the translatable fields of the original. Keys that point to non-translatable properties in the 
        /// target or to properties that do not exist in the target object MUST be ignored.
        /// </summary>
        [JsonProperty("contents")]
        [BsonElement("contents")]
        public Dictionary<string, object>? Contents { get; set; }


    }
}

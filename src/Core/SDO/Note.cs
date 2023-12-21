using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SDO
{
    /*
     
        abstract (String)
        content (String, required)
        authors (List of Strings)
        object_refs (List of References, required)
     */

    /// <summary>
    /// A Note is intended to convey informative text to provide further context and/or to provide additional analysis not contained in the STIX Objects, 
    /// Marking Definition objects, or Language Content objects which the Note relates to. Notes can be created by anyone (not just the original object creator).
    /// 
    /// For example, an analyst may add a Note to a Campaign object created by another organization indicating that they've seen posts related to that Campaign on a hacker forum.
    /// 
    /// Because Notes are typically (though not always) created by human analysts and are comprised of human-oriented text, they contain an additional property to capture 
    /// the analyst(s) that created the Note. This is distinct from the created_by_ref property, which is meant to capture the organization that created the object.
    /// </summary>
    public class Note : SdoStix
    {
        public Note(string objectType = "note") { ObjectType = objectType; }

        /// <summary>
        /// A brief summary of the note content.
        /// </summary>
        [JsonProperty("abstract")]
        [BsonElement("abstract")]
        public string? Abstract { get; set; }

        /// <summary>
        /// The content of the note.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("content")]
        [BsonElement("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The name of the author(s) of this note (e.g., the analyst(s) that created it).
        /// </summary>
        [JsonProperty("authors")]
        [BsonElement("authors")]
        public List<string>? Authors { get; set; }

        /// <summary>
        /// The STIX Objects that the note is being applied to.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("object_refs")]
        [BsonElement("object_refs")]
        public List<string>? ObjectRefs { get; set; }

        /*
         
         Embedded Relationships:
            created_by_ref          identity
            object_marking_refs     list of type identifier (of type marking-definition)
            object_refs             list of type identifier (of type STIX Object)
         
         */

    }
}

using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The Directory object represents the properties common to a file system directory.
    /// </summary>
    public class Directory : ScoStix
    {
        public Directory()
        {
            ObjectType = "directory";
        }

        /// <summary>
        /// Specifies the path, as originally observed, to the directory on the file system.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("path")]
        [BsonElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// Specifies the observed encoding for the path. The value MUST be specified if the path is stored in a non-Unicode encoding. 
        /// This value MUST be specified using the corresponding name from the 2013-12-20 revision of the IANA character set registry 
        /// [Character Sets]. If the preferred MIME name for a character set is defined, this value MUST be used; if it is not defined, 
        /// then the Name value from the registry MUST be used instead.
        /// </summary>
        [JsonProperty("path_enc")]
        [BsonElement("path_enc")]
        public string? PathEnc { get; set; }

        /// <summary>
        /// Specifies the date/time the directory was created.
        /// </summary>
        [JsonProperty("ctime")]
        [BsonElement("ctime")]
        public DateTime? CTime { get; set; }

        /// <summary>
        /// Specifies the date/time the directory was last written to/modified.
        /// </summary>
        [JsonProperty("mtime")]
        [BsonElement("mtime")]
        public DateTime? MTime { get; set; }

        /// <summary>
        /// Specifies the date/time the directory was last accessed.
        /// </summary>
        [JsonProperty("atime")]
        [BsonElement("atime")]
        public DateTime? ATime { get; set; }

        /// <summary>
        /// Specifies a list of references to other File and/or Directory objects contained within the directory.
        /// The objects referenced in this list MUST be of type file or directory.
        /// </summary>
        [JsonProperty("contains_refs")]
        [BsonElement("contains_refs")]
        public List<string>? ContainsRefs { get; set; }



    }
}

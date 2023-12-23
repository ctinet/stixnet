using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The File object represents the properties of a file. A File object MUST contain at least one of hashes or name.
    /// </summary>
    public class File : ScoStix
    {
        public File() { ObjectType = "file"; }

        /// <summary>
        /// The File object defines the following extensions. In addition to these, producers MAY create their own.
        /// ntfs-ext, raster-image-ext, pdf-ext, archive-ext, windows-pebinary-ext
        /// 
        /// Dictionary keys MUST use the specification defined name (examples above) or be the id of a STIX Extension object, depending on the type of extension being used.
        /// The corresponding dictionary values MUST contain the contents of the extension instance.
        /// </summary>
        [JsonProperty("extensions")]
        [BsonElement("extensions")]
        public override Dictionary<string, byte[]>? Extensions { get; set; }

        /// <summary>
        /// Specifies a dictionary of hashes for the file.
        /// (When used with the Archive File Extension, this refers to the hash of the entire archive file, not its contents.)
        /// Dictionary keys MUST come from the hash-algorithm-ov open vocabulary.
        /// </summary>
        [JsonProperty("hashes")]
        [BsonElement("hashes")]
        public string? Hashes { get; set; }

        /// <summary>
        /// Specifies the size of the file, in bytes. The value of this property MUST NOT be negative.
        /// </summary>
        [JsonProperty("size")]
        [BsonElement("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Specifies the name of the file.
        /// </summary>
        [JsonProperty("name")]
        [BsonElement("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Specifies the observed encoding for the name of the file. This value MUST be specified using the corresponding name from the 2013-12-20 revision of the IANA 
        /// character set registry [Character Sets]. If the value from the Preferred MIME Name column for a character set is defined, this value MUST be used; if it is 
        /// not defined, then the value from the Name column in the registry MUST be used instead.
        /// 
        /// This property allows for the capture of the original text encoding for the file name, which may be forensically relevant; for example, a file on an NTFS volume 
        /// whose name was created using the windows-1251 encoding, commonly used for languages based on Cyrillic script.
        /// </summary>
        [JsonProperty("name_enc")]
        [BsonElement("name_enc")]
        public string? NameEnc { get; set; }

        /// <summary>
        /// Specifies the hexadecimal constant ("magic number") associated with a specific file format that corresponds to the file, if applicable.
        /// </summary>
        [JsonProperty("magic_number_hex")]
        [BsonElement("magic_number_hex")]
        public string? MagicNumberHex { get; set; }

        /// <summary>
        /// Specifies the MIME type name specified for the file, e.g., application/msword.
        /// Whenever feasible, this value SHOULD be one of the values defined in the Template column in the IANA media type registry [Media Types].
        /// 
        /// Maintaining a comprehensive universal catalog of all extant file types is obviously not possible. When specifying a MIME Type not included 
        /// in the IANA registry, implementers should use their best judgement so as to facilitate interoperability.
        /// </summary>
        [JsonProperty("mime_type")]
        [BsonElement("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Specifies the date/time the file was created.
        /// </summary>
        [JsonProperty("ctime")]
        [BsonElement("ctime")]
        public DateTime? CTime { get; set; }

        /// <summary>
        /// Specifies the date/time the file was last written to/modified.
        /// </summary>
        [JsonProperty("mtime")]
        [BsonElement("mtime")]
        public DateTime? MTime { get; set; }

        /// <summary>
        /// Specifies the date/time the file was last accessed.
        /// </summary>
        [JsonProperty("atime")]
        [BsonElement("atime")]
        public DateTime? ATime { get; set; }

        /// <summary>
        /// Specifies the parent directory of the file, as a reference to a Directory object.
        /// The object referenced in this property MUST be of type directory.
        /// </summary>
        [JsonProperty("parent_directory_ref")]
        [BsonElement("parent_directory_ref")]
        public string? ParentDirectoryRef { get; set; }

        /// <summary>
        /// Specifies a list of references to other Cyber-observable Objects contained within the 
        /// file, such as another file that is appended to the end of the file, or an IP address 
        /// that is contained somewhere in the file.
        /// This is intended for use cases other than those targeted by the Archive extension.
        /// </summary>
        [JsonProperty("contains_refs")]
        [BsonElement("contains_refs")]
        public List<string>? ContainsRefs { get; set; }

        /// <summary>
        /// Specifies the content of the file, represented as an Artifact object.
        /// The object referenced in this property MUST be of type artifact.
        /// </summary>
        [JsonProperty("content_ref")]
        [BsonElement("content_ref")]
        public string? ContentRef { get; set; }


    }
}

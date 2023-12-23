﻿using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The Artifact object permits capturing an array of bytes (8-bits), as a base64-encoded string, or linking to a file-like payload.
    /// One of payload_bin or url MUST be provided. It is incumbent on object creators to ensure that the URL is accessible for downstream consumers.
    /// </summary>
    public class Artifact : ScoStix
    {
        public Artifact()
        {
            ObjectType = "artifact";
        }

        /// <summary>
        /// Whenever feasible, this value SHOULD be one of the values defined in the Template column in the IANA media type registry [Media Types]. 
        /// Maintaining a comprehensive universal catalog of all extant file types is obviously not possible. When specifying a MIME Type not included 
        /// in the IANA registry, implementers should use their best judgement so as to facilitate interoperability.
        /// </summary>
        [JsonProperty("mime_type")]
        [BsonElement("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Specifies the binary data contained in the artifact as a base64-encoded string.
        /// This property MUST NOT be present if url is provided.
        /// </summary>
        [JsonProperty("payload_bin")]
        [BsonElement("payload_bin")]
        public object PayloadBin { get; set; }

        /// <summary>
        /// The value of this property MUST be a valid URL that resolves to the unencoded content.
        /// This property MUST NOT be present if payload_bin is provided.
        /// </summary>
        [JsonProperty("url")]
        [BsonElement("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Specifies a dictionary of hashes for the contents of the url or the payload_bin.
        /// This property MUST be present when the url property is present.
        /// Dictionary keys MUST come from the hash-algorithm-ov open vocabulary.
        /// </summary>
        [JsonProperty("hashes")]
        [BsonElement("hashes")]
        public Dictionary<string, string>? Hashes { get; set; }

        /// <summary>
        /// If the artifact is encrypted, specifies the type of encryption algorithm the binary data  (either via payload_bin or url) is encoded in.
        /// The value of this property MUST come from the encryption-algorithm-enum enumeration.
        /// If both mime_type and encryption_algorithm are included, this signifies that the artifact represents an encrypted archive.
        /// </summary>
        [JsonProperty("encryption_algorithm")]
        [BsonElement("encryption_algorithm")]
        public string? EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Specifies the decryption key for the encrypted binary data (either via payload_bin or url). For example, this may be useful in cases of 
        /// sharing malware samples, which are often encoded in an encrypted archive.
        /// This property MUST NOT be present when the encryption_algorithm property is absent.
        /// </summary>
        [JsonProperty("decryption_key")]
        [BsonElement("decryption_key")]
        public string? decryption_key { get; set; }
    }
}

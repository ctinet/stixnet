using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The X.509 Certificate object represents the properties of an X.509 certificate, as defined by ITU 
    /// recommendation X.509 [X.509]. An X.509 Certificate object MUST contain at least one object specific 
    /// property (other than type) from this object.
    /// </summary>
    public class X509Certificate : ScoStix
    {
        public X509Certificate()
        {
            ObjectType = "x509-certificate";
        }

        /// <summary>
        /// Specifies whether the certificate is self-signed, i.e., whether it is signed by the same entity whose identity it certifies.
        /// </summary>
        [JsonProperty("is_self_signed")]
        [BsonElement("is_self_signed")]
        public bool? IsSelfSigned { get; set; }

        /// <summary>
        /// Specifies any hashes that were calculated for the entire contents of the certificate.
        /// Dictionary keys MUST come from the hash-algorithm-ov open vocabulary.
        /// </summary>
        [JsonProperty("hashes")]
        [BsonElement("hashes")]
        public Dictionary<string, string>? Hashes { get; set; }

        /// <summary>
        /// Specifies the version of the encoded certificate.
        /// </summary>
        [JsonProperty("version")]
        [BsonElement("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Specifies the unique identifier for the certificate, as issued by a specific Certificate Authority.
        /// </summary>
        [JsonProperty("serial_number")]
        [BsonElement("serial_number")]
        public string? SerialNumber { get; set; }

        /// <summary>
        /// Specifies the name of the algorithm used to sign the certificate.
        /// </summary>
        [JsonProperty("signature_algorithm")]
        [BsonElement("signature_algorithm")]
        public string? SignatureAlgorithm { get; set; }

        /// <summary>
        /// Specifies the name of the Certificate Authority that issued the certificate.
        /// </summary>
        [JsonProperty("issuer")]
        [BsonElement("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        /// Specifies the date on which the certificate validity period begins.
        /// </summary>
        [JsonProperty("validity_not_before")]
        [BsonElement("validity_not_before")]
        public DateTime? ValidityNotBefore { get; set; }

        /// <summary>
        /// Specifies the date on which the certificate validity period ends.
        /// </summary>
        [JsonProperty("validity_not_after")]
        [BsonElement("validity_not_after")]
        public DateTime? ValidityNotAfter { get; set; }

        /// <summary>
        /// Specifies the name of the entity associated with the public key stored in the subject public key field of the certificate.
        /// </summary>
        [JsonProperty("subject")]
        [BsonElement("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Specifies the name of the algorithm with which to encrypt data being sent to the subject.
        /// </summary>
        [JsonProperty("subject_public_key_algorithm")]
        [BsonElement("subject_public_key_algorithm")]
        public string? SubjectPublicKeyAlgorithm { get; set; }

        /// <summary>
        /// Specifies the modulus portion of the subject’s public RSA key.
        /// </summary>
        [JsonProperty("subject_public_key_modulus")]
        [BsonElement("subject_public_key_modulus")]
        public string? SubjectPublicKeyModulus { get; set; }

        /// <summary>
        /// Specifies the exponent portion of the subject’s public RSA key, as an integer.
        /// </summary>
        [JsonProperty("subject_public_key_exponent")]
        [BsonElement("subject_public_key_exponent")]
        public int? SubjectPublicKeyExponent { get; set; }

        /// <summary>
        /// Specifies any standard X.509 v3 extensions that may be used in the certificate.
        /// </summary>
        [JsonProperty("x509_v3_extensions")]
        [BsonElement("x509_v3_extensions")]
        public string? X509V3Extensions { get; set; }
    }
}

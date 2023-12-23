namespace Cti.Stix.Types
{
    /// <summary>
    /// The X.509 v3 Extensions type captures properties associated with X.509 v3 extensions, which serve as a mechanism for 
    /// specifying additional information such as alternative subject names. An object using the X.509 v3 Extensions type MUST 
    /// contain at least one property from this type.
    /// Note that the use of the term "extensions" in this context refers to the X.509 v3 Extensions type and is not a STIX 
    /// Cyber Observables extension. Therefore, it is a type that describes X.509 extensions.
    /// </summary>
    public class X509V3ExtensionsType
    {
        // Todo: x509-v3-extensions-type
        // basic_constraints(optional)                          string          Specifies a multi-valued extension which indicates whether a certificate is a
        //                                                                      CA certificate.The first(mandatory) name is CA followed by TRUE or FALSE.
        //                                                                      If CA is TRUE, then an optional pathlen name followed by a non-negative value
        //                                                                      can be included.Also equivalent to the object ID (OID) value of 2.5.29.19.
        // name_constraints (optional)                          string          Specifies a namespace within which all subject names in subsequent certificates
        //                                                                      in a certification path MUST be located.Also equivalent to the object ID (OID)
        //                                                                      value of 2.5.29.30.
        // policy_constraints (optional)                        string          Specifies any constraints on path validation for certificates issued to CAs. Also
        //                                                                      equivalent to the object ID (OID) value of 2.5.29.36.
        // key_usage (optional)                                 string          Specifies a multi-valued extension consisting of a list of names of the permitted
        //                                                                      key usages.Also equivalent to the object ID (OID) value of 2.5.29.15.
        // extended_key_usage (optional)                        string          Specifies a list of usages indicating purposes for which the certificate public key
        //                                                                      can be used for. Also equivalent to the object ID(OID) value of 2.5.29.37.
        // subject_key_identifier(optional)                     string          Specifies the identifier that provides a means of identifying certificates that
        //                                                                      contain a particular public key.Also equivalent to the object ID(OID) value of
        //                                                                      2.5.29.14.
        // authority_key_identifier(optional)                   string          Specifies the identifier that provides a means of identifying the public key
        //                                                                      corresponding to the private key used to sign a certificate.Also equivalent to
        //                                                                      the object ID (OID) value of 2.5.29.35.
        // subject_alternative_name (optional)                  string          Specifies the additional identities to be bound to the subject of the certificate.
        //                                                                      Also equivalent to the object ID (OID) value of 2.5.29.17.
        // issuer_alternative_name (optional)                   string          Specifies the additional identities to be bound to the issuer of the certificate.
        //                                                                      Also equivalent to the object ID (OID) value of 2.5.29.18.
        // subject_directory_attributes (optional)              string          Specifies the identification attributes (e.g., nationality) of the subject. Also equivalent to the object ID (OID) value of 2.5.29.9.
        // crl_distribution_points (optional)                   string          Specifies how CRL information is obtained.Also equivalent to the object ID (OID)
        //                                                                      value of 2.5.29.31.
        // inhibit_any_policy (optional)                        string          Specifies the number of additional certificates that may appear in the path before
        //                                                                      anyPolicy is no longer permitted.Also equivalent to the object ID (OID) value of
        //                                                                      2.5.29.54.
        // private_key_usage_period_not_before (optional)       timestamp       Specifies the date on which the validity period begins for the private key, if it
        //                                                                      is different from the validity period of the certificate.
        // private_key_usage_period_not_after(optional)         timestamp       Specifies the date on which the validity period ends for the private key, if it is
        //                                                                      different from the validity period of the certificate.
        // certificate_policies(optional)                       string          Specifies a sequence of one or more policy information terms, each of which consists
        //                                                                      of an object identifier(OID) and optional qualifiers.Also equivalent to the object
        //                                                                      ID(OID) value of 2.5.29.32.
        // policy_mappings(optional)                            string          Specifies one or more pairs of OIDs; each pair includes an issuerDomainPolicy and
        //                                                                      a subjectDomainPolicy.The pairing indicates whether the issuing CA considers its
        //                                                                      issuerDomainPolicy equivalent to the subject CA's subjectDomainPolicy.
        //                                                                      Also equivalent to the object ID (OID) value of 2.5.29.33.
    }
}

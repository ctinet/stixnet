using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.Net.Sockets;
using static System.Net.WebRequestMethods;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The Network Traffic object represents arbitrary network traffic that originates from a source and is addressed to a destination. 
    /// The network traffic MAY or MAY NOT constitute a valid unicast, multicast, or broadcast network connection. This MAY also include 
    /// traffic that is not established, such as a SYN flood.
    /// 
    /// To allow for use cases where a source or destination address may be sensitive and not suitable for sharing, such as addresses that 
    /// are internal to an organization’s network, the source and destination properties (src_ref and dst_ref, respectively) are defined as 
    /// optional in the properties table below. However, a Network Traffic object MUST contain the protocols property and at least one of 
    /// the src_ref or dst_ref properties and SHOULD contain the src_port and dst_port properties.
    /// </summary>
    public class NetworkTraffic : ScoStix
    {
        public NetworkTraffic() { ObjectType = "network-traffic"; }

        /// <summary>
        /// The Network Traffic object defines the following extensions. In addition to these, producers MAY create their own.
        /// http-request-ext, tcp-ext, icmp-ext, socket-ext
        /// 
        /// Dictionary keys MUST use the specification defined name (examples above) or be the id of a STIX Extension object, depending on the type of extension being used.
        /// 
        /// The corresponding dictionary values MUST contain the contents of the extension instance.
        /// </summary>
        [JsonProperty("extensions")]
        [BsonElement("extensions")]
        public override Dictionary<string, byte[]>? Extensions {  get; set; }

        /// <summary>
        /// Specifies the date/time the network traffic was initiated, if known.
        /// </summary>
        [JsonProperty("start")]
        [BsonElement("start")]
        public DateTime? Start { get; set; }

        /// <summary>
        /// Specifies the date/time the network traffic ended, if known.
        /// If the is_active property is true, then the end property MUST NOT be included.
        /// If this property and the start property are both defined, then this property MUST be greater than or equal to the timestamp in the start property.
        /// </summary>
        [JsonProperty("end")]
        [BsonElement("end")]
        public DateTime? End { get; set; }

        /// <summary>
        /// Indicates whether the network traffic is still ongoing.
        /// If the end property is provided, this property MUST be false.
        /// </summary>
        [JsonProperty("is_active")]
        [BsonElement("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Specifies the source of the network traffic, as a reference to a Cyber-observable Object.
        /// The object referenced MUST be of type ipv4-addr, ipv6-addr, mac-addr, or domain-name (for cases where the IP address for a domain name is unknown).
        /// </summary>
        [JsonProperty("src_ref")]
        [BsonElement("src_ref")]
        public string? SrcRef { get; set; }

        /// <summary>
        /// Specifies the destination of the network traffic, as a reference to a Cyber-observable Object.
        /// The object referenced MUST be of type ipv4-addr, ipv6-addr, mac-addr, or domain-name (for cases where the IP address for a domain name is unknown).
        /// </summary>
        [JsonProperty("dst_ref")]
        [BsonElement("dst_ref")]
        public string? DstRef { get; set; }

        /// <summary>
        /// Specifies the source port used in the network traffic, as an integer. The port value MUST be in the range of 0 - 65535.
        /// </summary>
        [JsonProperty("src_port")]
        [BsonElement("src_port")]
        public string? SrcPort { get; set; }

        /// <summary>
        /// Specifies the destination port used in the network traffic, as an integer. The port value MUST be in the range of 0 - 65535.
        /// </summary>
        [JsonProperty("dst_port")]
        [BsonElement("dst_port")]
        public string? DstPort { get; set; }

        /// <summary>
        /// Specifies the protocols observed in the network traffic, along with their corresponding state.
        /// Protocols MUST be listed in low to high order, from outer to inner in terms of packet encapsulation. That is, the protocols in the outer level of the 
        /// packet, such as IP, MUST be listed first.
        /// The protocol names SHOULD come from the service names defined in the Service Name column of the IANA Service Name and Port Number Registry [Port Numbers]. 
        /// In cases where there is variance in the name of a network protocol not included in the IANA Registry, content producers should exercise their best judgement, 
        /// and it is recommended that lowercase names be used for consistency with the IANA registry.
        /// 
        /// If the protocol extension is present, the corresponding protocol value for that extension SHOULD be listed in this property.
        /// Examples:
        /// ipv4, tcp, http
        /// ipv4, udp
        /// ipv6, tcp, http
        /// ipv6, tcp, ssl, https
        /// </summary>
        [JsonProperty("protocols")]
        [BsonElement("protocols")]
        public List<string>? Protocols { get; set; }

        /// <summary>
        /// Specifies the number of bytes, as a positive integer, sent from the source to the destination.
        /// </summary>
        [JsonProperty("src_byte_count")]
        [BsonElement("src_byte_count")]
        public int? SrcByteCount { get; set; }

        /// <summary>
        /// Specifies the number of bytes, as a positive integer, sent from the destination to the source.
        /// </summary>
        [JsonProperty("dst_byte_count")]
        [BsonElement("dst_byte_count")]
        public int? DstByteCount { get; set; }

        /// <summary>
        /// Specifies the number of packets, as a positive integer, sent from the source to the destination.
        /// </summary>
        [JsonProperty("src_packets")]
        [BsonElement("src_packets")]
        public int? SrcPackets { get; set; }

        /// <summary>
        /// Specifies the number of packets, as a positive integer, sent from the destination to the source.
        /// </summary>
        [JsonProperty("dst_packets")]
        [BsonElement("dst_packets")]
        public int? DstPackets { get; set; }

        /// <summary>
        /// Specifies any IP Flow Information Export [IPFIX] data for the traffic, as a dictionary. Each key/value 
        /// pair in the dictionary represents the name/value of a single IPFIX element. Accordingly, each dictionary 
        /// key SHOULD be a case-preserved version of the IPFIX element name, e.g., octetDeltaCount. Each dictionary 
        /// value MUST be either an integer or a string, as well as a valid IPFIX property.
        /// </summary>
        [JsonProperty("ipfix")]
        [BsonElement("ipfix")]
        public Dictionary<string, object>? Ipfix { get; set; }

        /// <summary>
        /// Specifies the bytes sent from the source to the destination.
        /// The object referenced in this property MUST be of type artifact.
        /// </summary>
        [JsonProperty("src_payload_ref")]
        [BsonElement("src_payload_ref")]
        public string? SrcPayloadRef { get; set; }

        /// <summary>
        /// Specifies the bytes sent from the destination to the source.
        /// The object referenced in this property MUST be of type artifact.
        /// </summary>
        [JsonProperty("dst_payload_ref")]
        [BsonElement("dst_payload_ref")]
        public string? DstPayloadRef { get; set; }

        /// <summary>
        /// Links to other network-traffic objects encapsulated by this network-traffic object.
        /// The objects referenced in this property MUST be of type network-traffic.
        /// </summary>
        [JsonProperty("encapsulates_refs")]
        [BsonElement("encapsulates_refs")]
        public List<string>? EncapsulatesRefs { get; set; }

        /// <summary>
        /// Links to another network-traffic object which encapsulates this object.
        /// The object referenced in this property MUST be of type network-traffic.
        /// </summary>
        [JsonProperty("encapsulated_by_ref")]
        [BsonElement("encapsulated_by_ref")]
        public string? EncapsulatedByRef { get; set; }
    }

    /// <summary>
    /// The HTTP request extension specifies a default extension for capturing network traffic properties specific to HTTP requests. The key for this extension 
    /// when used in the extensions dictionary MUST be http-request-ext. Note that this predefined extension does not use the extension facility described in 
    /// section 7.3. The corresponding protocol value for this extension is http.
    /// </summary>
    public class HttpRequestExtensions
    {
        // Todo: http-request-ext
        // request_method (required)        string          Specifies the HTTP method portion of the HTTP request line, as a lowercase string.
        // request_value (required)         string          Specifies the value (typically a resource path) portion of the HTTP request line.
        // request_version(optional)        string          Specifies the HTTP version portion of the HTTP request line, as a lowercase string.
        // request_header(optional)         dictionary      Specifies all of the HTTP header fields that may be found in the HTTP client request, as a dictionary.
        //                                                  Each key in the dictionary MUST be the name of the header field and SHOULD preserve case, e.g., User-Agent.
        //                                                  The corresponding value for each dictionary key MUST always be a list of type string to support when a header field is repeated.
        // message_body_length (optional)   integer         Specifies the length of the HTTP message body, if included, in bytes.
        // message_body_data_ref (optional) identifier      Specifies the data contained in the HTTP message body, if included.
        //                                                  The object referenced in this property MUST be of type artifact.
    }

    /// <summary>
    /// The ICMP extension specifies a default extension for capturing network traffic properties specific to ICMP. The key for this extension when used in the extensions dictionary MUST 
    /// be icmp-ext. Note that this predefined extension does not use the extension facility described in section 7.3. The corresponding protocol value for this extension is icmp.
    /// </summary>
    public class IcmpExtensions
    {
        // Todo: icmp-ext
        // icmp_type_hex (required)     hex         Specifies the ICMP type byte.
        // icmp_code_hex (required)     hex         Specifies the ICMP code byte.
    }

    /// <summary>
    /// The Network Socket extension specifies a default extension for capturing network traffic properties associated with network sockets. The key for this extension when used in the 
    /// extensions dictionary MUST be socket-ext. Note that this predefined extension does not use the extension facility described in section 7.3.
    /// </summary>
    public class NetworkSocketExtension
    {
        // Todo: socket-ext
        // address_family (required)            enum        Specifies the address family (AF_*) that the socket is configured for.
        //                                                  The values of this property MUST come from the network-socket-address-family-enum enumeration.
        // is_blocking (optional)               boolean     Specifies whether the socket is in blocking mode.
        // is_listening (optional)              boolean     Specifies whether the socket is in listening mode.
        // options (optional)                   dictionary  Specifies any options (e.g., SO_*) that may be used by the socket, as a dictionary. Each key in the dictionary SHOULD
        //                                                  be a case-preserved version of the option name, e.g., SO_ACCEPTCONN. Each key value in the dictionary MUST be the value
        //                                                  for the corresponding options key.  Each dictionary value MUST be an integer.  For SO_RCVTIMEO, SO_SNDTIMEO and SO_LINGER
        //                                                  the value represents the number of milliseconds.  If the SO_LINGER key is present, it indicates that the SO_LINGER option is active.
        // socket_type (optional)               enum        Specifies the type of the socket. The values of this property MUST come from the network-socket-type-enum enumeration.
        // socket_descriptor (optional)         integer     Specifies the socket file descriptor value associated with the socket, as a non-negative integer.
        // socket_handle (optional)             integer     Specifies the handle or inode value associated with the socket.
    }

    /// <summary>
    /// The TCP extension specifies a default extension for capturing network traffic properties specific to TCP. The key for this extension when used in the extensions dictionary MUST be tcp-ext. 
    /// Note that this predefined extension does not use the extension facility described in section 7.3. The corresponding protocol value for this extension is tcp.
    /// An object using the TCP Extension MUST contain at least one property from this extension.
    /// </summary>
    public class TcpExtensions
    {
        // Todo: tcp-ext
        // src_flags_hex (optional)             hex         Specifies the source TCP flags, as the union of all TCP flags observed between the start of the traffic(as defined by
        //                                                  the start property) and the end of the traffic(as defined by the end property).
        //                                                  If the start and end times of the traffic are not specified, this property SHOULD be interpreted as the union of all
        //                                                  TCP flags observed over the entirety of the network traffic being reported upon.
        // dst_flags_hex(optional)              hex         Specifies the destination TCP flags, as the union of all TCP flags observed between the start of the traffic(as defined
        //                                                  by the start property) and the end of the traffic(as defined by the end property).
        //                                                  If the start and end times of the traffic are not specified, this property SHOULD be interpreted as the union of all
        //                                                  TCP flags observed over the entirety of the network traffic being reported upon.
    }
}

using Cti.Stix.Types;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The Email Message object represents an instance of an email message, corresponding to the internet message format described in [RFC5322] and related RFCs.
    /// 
    /// Header field values that have been encoded as described in section 2 of [RFC2047] MUST be decoded before inclusion in Email Message object properties. 
    /// For example, this is some text MUST be used instead of =?iso-8859-1?q?this=20is=20some=20text?=. Any characters in the encoded value which cannot be 
    /// decoded into Unicode SHOULD be replaced with the 'REPLACEMENT CHARACTER' (U+FFFD). If it is necessary to capture the header value as observed, this 
    /// can be achieved by referencing an Artifact object through the raw_email_ref property.
    /// </summary>
    public class EmailMessage : ScoStix
    {
        public EmailMessage()
        {
            ObjectType = "email-message";
        }

        /// <summary>
        /// Indicates whether the email body contains multiple MIME parts.
        /// </summary>
        [Required]
        [JsonRequired]
        [BsonRequired]
        [JsonProperty("is_multipart")]
        [BsonElement("is_multipart")]
        public bool IsMultipart { get; set; }

        /// <summary>
        /// Specifies the date/time that the email message was sent.
        /// </summary>
        [JsonProperty("date")]
        [BsonElement("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Specifies the value of the "Content-Type" header of the email message.
        /// </summary>
        [JsonProperty("content_type")]
        [BsonElement("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Specifies the value of the "From:" header of the email message. 
        /// The "From:" field specifies the author of the message, that is, 
        /// the mailbox(es) of the person or system responsible for the writing of the message.
        /// 
        /// The object referenced in this property MUST be of type email-address.
        /// </summary>
        [JsonProperty("from_ref")]
        [BsonElement("from_ref")]
        public string? FromRef { get; set; }

        /// <summary>
        /// Specifies the value of the "Sender" field of the email message. The "Sender:" field specifies 
        /// the mailbox of the agent responsible for the actual transmission of the message.
        /// 
        /// The object referenced in this property MUST be of type email-address.
        /// </summary>
        [JsonProperty("sender_ref")]
        [BsonElement("sender_ref")]
        public string? SenderRef { get; set; }

        /// <summary>
        /// Specifies the mailboxes that are "To:" recipients of the email message.
        /// 
        /// The objects referenced in this list MUST be of type email-address.
        /// </summary>
        [JsonProperty("to_refs")]
        [BsonElement("to_refs")]
        public List<string>? ToRefs { get; set; }


        /// <summary>
        /// Specifies the mailboxes that are "CC:" recipients of the email message.
        /// The objects referenced in this list MUST be of type email-address.
        /// </summary>
        [JsonProperty("cc_refs")]
        [BsonElement("cc_refs")]
        public List<string>? CcRefs { get; set; }

        /// <summary>
        /// Specifies the mailboxes that are "BCC:" recipients of the email message.
        /// As per [RFC5322], the absence of this property should not be interpreted as semantically equivalent to an absent BCC header on the message being characterized.
        /// The objects referenced in this list MUST be of type email-address.
        /// </summary>
        [JsonProperty("bcc_refs")]
        [BsonElement("bcc_refs")]
        public List<string>? BccRefs { get; set; }

        /// <summary>
        /// Specifies the Message-ID field of the email message.
        /// </summary>
        [JsonProperty("message_id")]
        [BsonElement("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// Specifies the subject of the email message.
        /// </summary>
        [JsonProperty("subject")]
        [BsonElement("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Specifies one or more "Received" header fields that may be included in the email headers.
        /// List values MUST appear in the same order as present in the email message.
        /// </summary>
        [JsonProperty("received_lines")]
        [BsonElement("received_lines")]
        public List<string>? ReceivedLines { get; set; }

        /// <summary>
        /// Specifies any other header fields (except for date, received_lines, content_type, from_ref, 
        /// sender_ref, to_refs, cc_refs, bcc_refs, and subject) found in the email message, as a dictionary.
        /// 
        /// Each key/value pair in the dictionary represents the name/value of a single header field or names/values 
        /// of a header field that occurs more than once. Each dictionary key SHOULD be a case-preserved version of 
        /// the header field name. The corresponding value for each dictionary key MUST always be a list of type string 
        /// to support when a header field is repeated.
        /// </summary>
        [JsonProperty("additional_header_fields")]
        [BsonElement("additional_header_fields")]
        public Dictionary<string, string>? AdditionalHeaderFields { get; set; }

        /// <summary>
        /// Specifies a string containing the email body. This property MUST NOT be used if is_multipart is true.
        /// </summary>
        [JsonProperty("body")]
        [BsonElement("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Specifies a list of the MIME parts that make up the email body. This property MUST NOT be used if is_multipart is false.
        /// </summary>
        [JsonProperty("body_multipart")]
        [BsonElement("body_multipart")]
        public List<EmailMimeComponentType>? BodyMultipart { get; set; }

        /// <summary>
        /// Specifies the raw binary contents of the email message, including both the headers and body, as a reference to an Artifact object.
        /// The object referenced in this property MUST be of type artifact.
        /// </summary>
        [JsonProperty("raw_email_ref")]
        [BsonElement("raw_email_ref")]
        public string? RawEmailRef { get; set; }


    }
}

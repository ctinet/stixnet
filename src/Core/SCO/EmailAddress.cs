using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The Email Address object represents a single email address.
    /// </summary>
    public class EmailAddress : ScoStix
    {

        public EmailAddress() { ObjectType = "email-addr"; }

        /// <summary>
        /// Specifies the value of the email address. This MUST NOT include the display name.
        /// This property corresponds to the addr-spec construction in section 3.4 of[RFC5322], for example, jane.smith @example.com.
        /// </summary>
        [JsonProperty("value")]
        [BsonElement("value")]
        public string Value { get; set; }

        /// <summary>
        /// Specifies a single email display name, i.e., the name that is displayed to the human user of a mail application.
        /// This property corresponds to the display-name construction in section 3.4 of [RFC5322], for example, Jane Smith.
        /// </summary>
        [JsonProperty("display_name")]
        [BsonElement("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Specifies the user account that the email address belongs to, as a reference to a User Account object.
        /// The object referenced in this property MUST be of type user-account.
        /// </summary>
        [JsonProperty("belongs_to_ref")]
        [BsonElement("belongs_to_ref")]
        public string? BelongsToRef { get; set; }
    }
}

using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.Security.Principal;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The User Account object represents an instance of any type of user account, including but not 
    /// limited to operating system, device, messaging service, and social media platform accounts. 
    /// As all properties of this object are optional, at least one of the properties defined below 
    /// MUST be included when using this object.
    /// </summary>
    public class UserAccount : ScoStix
    {
        public UserAccount() { ObjectType = "user-account"; }

        /// <summary>
        /// The User Account object defines the following extensions. In addition to these, producers MAY create their own.
        /// unix-account-ext
        /// Dictionary keys MUST use the specification defined name (examples above) or be the id of a STIX Extension object, 
        /// depending on the type of extension being used.
        /// The corresponding dictionary values MUST contain the contents of the extension instance.
        /// </summary>
        [JsonProperty("extensions")]
        [BsonElement("extensions")]
        public override Dictionary<string, byte[]>? Extensions { get; set; }

        /// <summary>
        /// Specifies the identifier of the account. The format of the identifier depends on the system 
        /// the user account is maintained in, and may be a numeric ID, a GUID, an account name, 
        /// an email address, etc. The user_id property should be populated with whatever field is the 
        /// unique identifier for the system the account is a member of. For example, on UNIX systems 
        /// it would be populated with the UID.
        /// </summary>
        [JsonProperty("user_id")]
        [BsonElement("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Specifies a cleartext credential. This is only intended to be used in capturing metadata from 
        /// malware analysis (e.g., a hard-coded domain administrator password that the malware attempts 
        /// to use for lateral movement) and SHOULD NOT be used for sharing of PII.
        /// </summary>
        [JsonProperty("credential")]
        [BsonElement("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// Specifies the account login string, used in cases where the user_id property specifies something 
        /// other than what a user would type when they login.
        /// For example, in the case of a Unix account with user_id 0, the account_login might be "root".
        /// </summary>
        [JsonProperty("account_login")]
        [BsonElement("account_login")]
        public string? AccountLogin { get; set; }

        /// <summary>
        /// Specifies the type of the account.
        /// This is an open vocabulary and values SHOULD come from the account-type-ov open vocabulary.
        /// </summary>
        [JsonProperty("account_type")]
        [BsonElement("account_type")]
        public string? AccountType { get; set; }

        /// <summary>
        /// Specifies the display name of the account, to be shown in user interfaces, if applicable.
        /// On Unix, this is equivalent to the GECOS field.
        /// </summary>
        [JsonProperty("display_name")]
        [BsonElement("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Indicates that the account is associated with a network service or system process (daemon), not a specific individual.
        /// </summary>
        [JsonProperty("is_service_account")]
        [BsonElement("is_service_account")]
        public bool? IsServiceAccount { get; set; }

        /// <summary>
        /// Specifies that the account has elevated privileges (i.e., in the case of root on Unix or the Windows Administrator account).
        /// </summary>
        [JsonProperty("is_privileged")]
        [BsonElement("is_privileged")]
        public bool? IsPrivileged { get; set; }

        /// <summary>
        /// Specifies that the account has the ability to escalate privileges (i.e., in the case of sudo on Unix or a Windows Domain Admin account)
        /// </summary>
        [JsonProperty("can_escalate_privs")]
        [BsonElement("can_escalate_privs")]
        public bool? CanEscalatePrivs { get; set; }

        /// <summary>
        /// Specifies if the account is disabled.
        /// </summary>
        [JsonProperty("is_disabled")]
        [BsonElement("is_disabled")]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Specifies when the account was created.
        /// </summary>
        [JsonProperty("account_created")]
        [BsonElement("account_created")]
        public DateTime? AccountCreated { get; set; }

        /// <summary>
        /// Specifies the expiration date of the account.
        /// </summary>
        [JsonProperty("account_expires")]
        [BsonElement("account_expires")]
        public DateTime? AccountExpires { get; set; }

        /// <summary>
        /// Specifies when the account credential was last changed.
        /// </summary>
        [JsonProperty("credential_last_changed")]
        [BsonElement("credential_last_changed")]
        public DateTime? CredentialLastChanged { get; set; }

        /// <summary>
        /// Specifies when the account was first accessed.
        /// </summary>
        [JsonProperty("account_first_login")]
        [BsonElement("account_first_login")]
        public DateTime? AccountFirstLogin { get; set; }

        /// <summary>
        /// Specifies when the account was last accessed.
        /// </summary>
        [JsonProperty("account_last_login")]
        [BsonElement("account_last_login")]
        public DateTime? AccountLastLogin { get; set; }
    }

    /// <summary>
    /// The UNIX account extension specifies a default extension for capturing the additional information 
    /// for an account on a UNIX system. The key for this extension when used in the extensions dictionary 
    /// MUST be unix-account-ext. Note that this predefined extension does not use the extension facility 
    /// described in section 7.3.
    /// An object using the UNIX Account Extension MUST contain at least one property from this extension.
    /// </summary>
    public class UNIXAccountExtension
    {
        // Todo: unix-account-ext
        // gid (optional)           integer                 Specifies the primary group ID of the account.
        // groups (optional)        list of type string     Specifies a list of names of groups that the account is a member of.
        // home_dir (optional)      string                  Specifies the home directory of the account.
        // shell (optional)         string                  Specifies the account’s command shell.
    }
}

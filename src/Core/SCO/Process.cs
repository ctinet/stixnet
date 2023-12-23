using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Cti.Stix.Core.SCO
{
    /// <summary>
    /// The Process object represents common properties of an instance of a computer program as executed on an operating system. 
    /// A Process object MUST contain at least one property (other than type) from this object (or one of its extensions).
    /// </summary>
    public class Process : ScoStix
    {
        public Process() { ObjectType = "process"; }

        /// <summary>
        /// The Process object defines the following extensions. In addition to these, producers MAY create their own.
        /// windows-process-ext, windows-service-ext
        /// Dictionary keys MUST use the specification defined name (examples above) or be the id of a STIX Extension object, depending on the type of extension being used.
        /// The corresponding dictionary values MUST contain the contents of the extension instance.
        /// </summary>
        [JsonProperty("extensions")]
        [BsonElement("extensions")]
        public override Dictionary<string, byte[]>? Extensions {  get; set; }

        /// <summary>
        /// Specifies whether the process is hidden.
        /// </summary>
        [JsonProperty("is_hidden")]
        [BsonElement("is_hidden")]
        public bool? IsHidden { get; set; }

        /// <summary>
        /// Specifies the Process ID, or PID, of the process.
        /// </summary>
        [JsonProperty("pid")]
        [BsonElement("pid")]
        public int? Pid { get; set; }

        /// <summary>
        /// Specifies the date/time at which the process was created.
        /// </summary>
        [JsonProperty("created_time")]
        [BsonElement("created_time")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Specifies the current working directory of the process.
        /// </summary>
        [JsonProperty("cwd")]
        [BsonElement("cwd")]
        public string? Cwd { get; set; }

        /// <summary>
        /// Specifies the full command line used in executing the process, including the process name (which may be specified individually via the image_ref.name property) and any arguments.
        /// </summary>
        [JsonProperty("command_line")]
        [BsonElement("command_line")]
        public string? CommandLine { get; set; }

        /// <summary>
        /// Specifies the list of environment variables associated with the process as a dictionary. Each key in the dictionary MUST be a case preserved version of the name of 
        /// the environment variable, and each corresponding value MUST be the environment variable value as a string.
        /// </summary>
        [JsonProperty("environment_variables")]
        [BsonElement("environment_variables")]
        public Dictionary<string, string>? EnvironmentVariables { get; set; }

        /// <summary>
        /// Specifies the list of network connections opened by the process, as a reference to one or more Network Traffic objects.
        /// The objects referenced in this list MUST be of type network-traffic.
        /// </summary>
        [JsonProperty("opened_connection_refs")]
        [BsonElement("opened_connection_refs")]
        public List<string>? OpenedConnectionRefs { get; set; }

        /// <summary>
        /// Specifies the user that created the process, as a reference to a User Account object.
        /// The object referenced in this property MUST be of type user-account.
        /// </summary>
        [JsonProperty("creator_user_ref")]
        [BsonElement("creator_user_ref")]
        public string? CreatorUserRef { get; set; }

        /// <summary>
        /// Specifies the executable binary that was executed as the process image, as a reference to a File object.
        /// The object referenced in this property MUST be of type file.
        /// </summary>
        [JsonProperty("image_ref")]
        [BsonElement("image_ref")]
        public string? ImageRef { get; set; }

        /// <summary>
        /// Specifies the other process that spawned (i.e. is the parent of) this one, as a reference to a Process object.
        /// The object referenced in this property MUST be of type process.
        /// </summary>
        [JsonProperty("parent_ref")]
        [BsonElement("parent_ref")]
        public string? ParentRef { get; set; }

        /// <summary>
        /// Specifies the other processes that were spawned by (i.e. children of) this process, as a reference to one or more other Process objects.
        /// The objects referenced in this list MUST be of type process.
        /// </summary>
        [JsonProperty("child_refs")]
        [BsonElement("child_refs")]
        public List<string>? ChildRefs { get; set; }


    }

    /// <summary>
    /// The Windows Process extension specifies a default extension for capturing properties specific to Windows processes. The key for this extension 
    /// when used in the extensions dictionary MUST be windows-process-ext. Note that this predefined extension does not use the extension facility 
    /// described in section 7.3. An object using the Windows Process Extension MUST contain at least one property from this extension.
    /// </summary>
    public class WindowsProcessExtension
    {
        // Todo:  windows-process-ext
        // aslr_enabled (optional)      boolean     Specifies whether Address Space Layout Randomization(ASLR) is enabled for the process.
        // dep_enabled(optional)        boolean     Specifies whether Data Execution Prevention(DEP) is enabled for the process.
        // priority(optional)           string      Specifies the current priority class of the process in Windows.This value SHOULD be a
        //                                          string that ends in _CLASS.
        // owner_sid(optional)          string      Specifies the Security ID(SID) value of the owner of the process.
        // window_title(optional)       string      Specifies the title of the main window of the process.
        // startup_info(optional)       dictionary  Specifies the STARTUP_INFO struct used by the process, as a dictionary.Each name/value
        //                                          pair in the struct MUST be represented as a key/value pair in the dictionary, where each
        //                                          key MUST be a case-preserved version of the original name.For example, given a name of
        //                                          "lpDesktop" the corresponding key would be lpDesktop.
        // integrity_level  (optional)  enum        Specifies the Windows integrity level, or trustworthiness, of the process. The values of
        //                                          this property MUST come from the windows-integrity-level-enum enumeration.
    }

    /// <summary>
    /// The Windows Service extension specifies a default extension for capturing properties specific to Windows services. The key for this 
    /// extension when used in the extensions dictionary MUST be windows-service-ext. Note that this predefined extension does not use the 
    /// extension facility described in section 7.3.
    /// As all properties of this extension are optional, at least one of the properties defined below MUST be included when using this extension.
    /// </summary>
    public class WindowsServiceExtension
    {
        // Todo:  windows-service-ext
        // service_name (optional)      string                  Specifies the name of the service.
        // descriptions(optional)       list of type string     Specifies the descriptions defined for the service.
        // display_name(optional)       string                  Specifies the display name of the service in Windows GUI controls.
        // group_name(optional)         string                  Specifies the name of the load ordering group of which the service is a member.
        // start_type(optional)         enum                    Specifies the start options defined for the service.
        //                                                      The values of this property MUST come from the windows-service-start-type-enum enumeration.
        // service_dll_refs(optional)   list of type identifier Specifies the DLLs loaded by the service, as a reference to one or more File objects.
        //                                                      The objects referenced in this property MUST be of type file.
        // service_type (optional)      enum                    Specifies the type of the service. The values of this property MUST come from the
        //                                                      windows-service-type-enum enumeration.
        // service_status(optional)     enum                    Specifies the current status of the service.
        //                                                      The values of this property MUST come from the windows-service-status-enum enumeration.
    }
}

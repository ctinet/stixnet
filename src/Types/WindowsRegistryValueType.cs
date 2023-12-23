namespace Cti.Stix.Types
{
    /// <summary>
    /// The Windows Registry Value type captures the properties of a Windows Registry Key Value. As all 
    /// properties of this type are optional, at least one of the properties defined below MUST be 
    /// included when using this type.
    /// </summary>
    public class WindowsRegistryValueType
    {
        // Todo: windows-registry-value-type
        // name (optional)          string          Specifies the name of the registry value. For specifying the default value in a
        //                                          registry key, an empty string MUST be used.
        // data (optional)          string          Specifies the data contained in the registry value.
        // data_type (optional)     enum            Specifies the registry (REG_*) data type used in the registry value.
        //                                          The values of this property MUST come from the windows-registry-datatype-enum enumeration.
    }
}

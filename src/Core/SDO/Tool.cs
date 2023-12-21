namespace Cti.Stix.Core.SDO
{
    /*
     
class Tool(allow_custom=False, **kwargs)
For more detailed information on this object’s properties, see the STIX 2.1 specification.

Properties:	
spec_version (String)
id (ID)
created_by_ref (Reference)
created (Timestamp, default: current date/time)
modified (Timestamp, default: current date/time)
name (String, required)
description (String)
tool_types (List of Open Vocabs)
aliases (List of Strings)
kill_chain_phases (List of Kill Chain Phases)
tool_version (String)
revoked (Boolean)
labels (List of Strings)
confidence (Integer)
lang (String)
external_references (List of External References)
object_marking_refs (List of References)
granular_markings (List of Granular Markings)
extensions (Extensions)
     */
    public class Tool : SdoStix
    {
    }
}

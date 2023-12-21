namespace Cti.Stix.Core.SDO
{
    /*
     
class Opinion(allow_custom=False, **kwargs)
For more detailed information on this object’s properties, see the STIX 2.1 specification.

Properties:	
spec_version (String)
id (ID)
created_by_ref (Reference)
created (Timestamp, default: current date/time)
modified (Timestamp, default: current date/time)
explanation (String)
authors (List of Strings)
opinion (Enum, required)
object_refs (List of References, required)
revoked (Boolean)
labels (List of Strings)
confidence (Integer)
lang (String)
external_references (List of External References)
object_marking_refs (List of References)
granular_markings (List of Granular Markings)
extensions (Extensions)
     */
    public class Opinion : SdoStix
    {
    }
}

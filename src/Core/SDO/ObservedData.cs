namespace Cti.Stix.Core.SDO
{
    /*
     
class ObservedData(*args, **kwargs)
For more detailed information on this object’s properties, see the STIX 2.1 specification.

Properties:	
spec_version (String)
id (ID)
created_by_ref (Reference)
created (Timestamp, default: current date/time)
modified (Timestamp, default: current date/time)
first_observed (Timestamp, required)
last_observed (Timestamp, required)
number_observed (Integer, required)
objects (Observable)
object_refs (List of References)
revoked (Boolean)
labels (List of Strings)
confidence (Integer)
lang (String)
external_references (List of External References)
object_marking_refs (List of References)
granular_markings (List of Granular Markings)
extensions (Extensions)
     */
    public class ObservedData : SdoStix
    {
    }
}

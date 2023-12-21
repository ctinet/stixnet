namespace Cti.Stix.Core.SDO
{
    /*
     
class ThreatActor(allow_custom=False, **kwargs)
For more detailed information on this object’s properties, see the STIX 2.1 specification.

Properties:	
spec_version (String)
id (ID)
created_by_ref (Reference)
created (Timestamp, default: current date/time)
modified (Timestamp, default: current date/time)
name (String, required)
description (String)
threat_actor_types (List of Open Vocabs)
aliases (List of Strings)
first_seen (Timestamp)
last_seen (Timestamp)
roles (List of Open Vocabs)
goals (List of Strings)
sophistication (Open Vocab)
resource_level (Open Vocab)
primary_motivation (Open Vocab)
secondary_motivations (List of Open Vocabs)
personal_motivations (List of Open Vocabs)
revoked (Boolean)
labels (List of Strings)
confidence (Integer)
lang (String)
external_references (List of External References)
object_marking_refs (List of References)
granular_markings (List of Granular Markings)
extensions (Extensions)
     */
    public class ThreatActor : SdoStix
    {
    }
}

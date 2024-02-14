
# stixnet
	
A C# API for STIX 2

![CI](https://github.com/ctinet/stixnet/actions/workflows/dotnet.yml/badge.svg)
![CodeQL](https://github.com/ctinet/stixnet/actions/workflows/codeql.yml/badge.svg)
![Nuget](https://github.com/ctinet/stixnet/actions/workflows/nuget.yml/badge.svg)

#### Install from Nuget

[![NuGet version (stixnet)](https://img.shields.io/nuget/v/stixnet?label=stixnet&logo=nuget)](https://www.nuget.org/packages/stixnet/)

```pwsh
Install-Package stixnet
```

## What is STIX?

Structured Threat Information Expression (STIX) is a language and serialization format used to exchange cyber threat intelligence (CTI). STIX enables organizations to share CTI with one another in a consistent and machine-readable manner, allowing security communities to better understand what computer-based attacks they are most likely to see and to anticipate and/or respond to those attacks faster and more effectively. STIX is designed to improve many different capabilities, such as collaborative threat analysis, automated threat exchange, automated detection and response, and more.
The objects and features added for inclusion in STIX 2.1 represent an iterative approach to fulfilling basic consumer and producer requirements for CTI sharing. Objects and properties not included in this version of STIX, but deemed necessary by the community, will be included in future releases.


STIX is a schema that defines a taxonomy of cyber threat intelligence that is represented by the following objects:

1. STIX Bundle Object : An object that provides a wrapper mechanism for packaging arbitrary STIX content together
2. STIX Objects
    1. STIX Core Objects
		1. STIX Domain Objects (SDO) : Higher Level Intelligence Objects that represent behaviors and constructs that threat analysts would typically create or work with while understanding the threat landscape.
		2. STIX Cyber-observable Objects (SCO) : Objects that represent observed facts about a network or host that may be used and related to higher level intelligence to form a more complete understanding of the threat landscape.
	    3. STIX Relationship Objects (SRO) : Objects that connect STIX Domain Objects together, STIX Cyber-observable Objects together, and connect STIX Domain Objects and STIX Cyber-observable Objects together to form a more complete understanding of the threat landscape.
	2. STIX Meta Objects (SMO) : A STIX Object that provides the necessary glue and associated metadata to enrich or extend STIX Core Objects to support user and system workflows.
		1. Extension Definition Objects
		2. Language Content Objects
		3. Marking Definition Objects


![stix2_relationship_example](https://github.com/ctinet/stixnet/raw/main/docs/relationships.png)


<details>
	<summary>Common Data Types</summary>

| Type| Description |
|-----|-------------|
| binary | A sequence of bytes. |
| boolean | A value of true or false. |
| dictionary | A set of key/value pairs. |
| enum | A value from a STIX Enumeration. |
| external-reference | A non-STIX identifier or reference to other related external content. |
| float | An IEEE 754 [IEEE 754-2008] double-precision number. |
| hashes | One or more cryptographic hashes. |
| hex | An array of octets as hexadecimal. |
| identifier | An identifier (ID) is for STIX Objects. |
| integer | A whole number. |
| kill-chain-phase | A name and a phase of a kill chain. |
| list | A sequence of values ordered based on how they appear in the list. The phrasing "list of type <type>
	" is used to indicate that all values within the list MUST conform to the specified type. |
	| observable-container | One or more STIX Cyber-observable Objects in the deprecated Cyber Observable Container. |
	| open-vocab | A value from a STIX open (open-vocab) or suggested vocabulary. |
	| string | A series of Unicode characters. |
	| timestamp | A time value (date and time). |

</details>

<details>
	<summary>Common Properties</summary>

| � | STIX Core Objects |  |  | STIX Meta Objects |  |  | � |
| --- | --- | --- | --- | --- | --- | --- | --- |
|  **Property Name**  |  **SDOs**  |  **SROs**  |  **SCOs**  |  **Extension**  |  **Language**  |  **Markings**  |  **Bundle**  |
|  _type_ | Required | Required | Required | Required | Required | Required | Required |
|  _spec\_version_  | Required | Required | Optional | Required | Required | Required | N/A |
|  _id_  | Required | Required | Required | Required | Required | Required | Required |
|  _created\_by\_ref_  | Optional | Optional | N/A | Required | Optional | Optional | N/A |
|  _created_  | Required | Required | N/A | Required | Required | Required | N/A |
|  _modified_  | Required | Required | N/A | Required | Required | N/A | N/A |
|  _revoked_  | Optional | Optional | N/A | Optional | Optional | N/A | N/A |
|  _labels_  | Optional | Optional | N/A | Optional | Optional | N/A | N/A |
|  _confidence_  | Optional | Optional | N/A | N/A | Optional | N/A | N/A |
|  _lang_  | Optional | Optional | N/A | N/A | N/A | N/A | N/A |
|  _external\_references_  | Optional | Optional | N/A | Optional | Optional | Optional | N/A |
|  _object\_marking\_refs_  | Optional | Optional | Optional | Optional | Optional | Optional | N/A |
|  _granular\_markings_  | Optional | Optional | Optional | Optional | Optional | Optional | N/A |
|  _defanged_  | N/A | N/A | Optional | N/A | N/A | N/A | N/A |
|  _extensions_  | Optional | Optional | Optional | N/A | Optional | Optional | N/A |

</details>


<details>
	<summary>STIX Objects</summary>

1. [STIX Domain Objects](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_nrhq5e9nylke)
1.  [Attack Pattern](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_axjijf603msy)
2.  [Campaign](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_pcpvfz4ik6d6)
3.  [Course of Action](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_a925mpw39txn)
4.  [Grouping](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_t56pn7elv6u7)
5.  [Identity](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_wh296fiwpklp)
6.  [Incident](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_sczfhw64pjxt)
7.  [Indicator](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_muftrcpnf89v)
8.  [Infrastructure](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_jo3k1o6lr9)
9.  [Intrusion Set](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_5ol9xlbbnrdn)
10. [Location](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_th8nitr8jb4k)
11. [Malware](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_s5l7katgbp09)
12. [Malware Analysis](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_6hdrixb3ua4j)
13. [Note](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_gudodcg1sbb9)
14. [Observed Data](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_p49j1fwoxldc)
15. [Opinion](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_ht1vtzfbtzda)
16. [Report](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_n8bjzg1ysgdq)
17. [Threat Actor](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_k017w16zutw)
18. [Tool](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_z4voa9ndw8v)
19. [Vulnerability](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_q5ytzmajn6re)
2. [STIX Relationship Objects](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_cqhkqvhnlgfh)
1. [Relationship](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_e2e1szrqfoan)
2. [Sighting](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_a795guqsap3r)
3. [STIX Cyber-observable Objects](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_mlbmudhl16lr)
1. [Artifact Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_4jegwl6ojbes)
2. [Autonomous System (AS) Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_27gux0aol9e3)
3. [Directory Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_lyvpga5hlw52)
4. [Domain Name Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_prhhksbxbg87)
5. [Email Address Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_wmenahkvqmgj)
6. [Email Message Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_grboc7sq5514)
1. [Email MIME Component Type](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_qpo5x7d8mefq)
7. [File Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_99bl2dibcztv)
1. [Archive File Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_xi3g7dwaigs6)
2. [NTFS File Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_o6cweepfrsci)
1. [Alternate Data Stream Type](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_8i2ts0xicqea)
3. [PDF File Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_8xmpb2ghp9km)
4. [Raster Image File Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_u5z7i2ox8w4x)
5. [Windows� PE Binary File Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_gg5zibddf9bs)
1. [Windows� PE Optional Header Type](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_29l09w731pzc)
2. [Windows� PE Section Type](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_ioapwyd8oimw)
8. [IPv4 Address Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_ki1ufj1ku8s0)
9. [IPv6 Address Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_oeggeryskriq)
10. [MAC Address Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_f92nr9plf58y)
11. [Mutex Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_84hwlkdmev1w)
12. [Network Traffic Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_rgnc3w40xy)
1. [HTTP Request Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_b0e376hgtml8)
2. [ICMP Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_ozypx0lmkebv)
3. [Network Socket Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_8jamupj9ubdv)
4. [TCP Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_k2njqio7f142)
13. [Process Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_hpppnm86a1jm)
1. [Windows� Process Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_oyegq07gjf5t)
2. [Windows� Service Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_lbcvc2ahx1s0)
14. [Software Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_7rkyhtkdthok)
15. [URL Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_ah3hict2dez0)
16. [User Account Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_azo70vgj1vm2)
1. [UNIX� Account Extension](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_hodiamlggpw5)
17. [Windows� Registry Key Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_luvw8wjlfo3y)
1. [Windows� Registry Value Type](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_u7n4ndghs3qq)
18. [X.509 Certificate Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_8abcy1o5x9w1)
1. [X.509 v3 Extensions Type](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_oudvonxzdlku)
4. [STIX Meta Objects](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_mq8oo9k9rb2)
1. [Language Content](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_z9r1cwtu8jja)
2. [Data Markings](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_95gfoglikdzh)
1. [Marking Definition](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_k5fndj2c7c1k)
1. [Statement Marking Object Type](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_3ru8r05saera)
2. [TLP Marking Object Type](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_yd3ar14ekwrs)
2. [Object Markings](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_bnienmcktc0n)
3. [Granular Markings](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_robezi5egfdr)
1. [Granular Marking Type](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_l6edgya0tyjq)
3. [Extension Definition](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_32j232tfvtly)
1. [Extension Definition Properties](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_267wue80wnvt)
2. [Requirements for STIX Extension Schemas](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_bhp6qqa5dk92)
1. [Requirements for Extension Properties](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_rw6dziuf97ib)
2. [Requirements for Extension STIX Objects](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_h6s93c8290cj)
5. [STIX Bundle Object](https://docs.oasis-open.org/cti/stix/v2.1/os/stix-v2.1-os.html#_gms872kuzdmg)

</details>

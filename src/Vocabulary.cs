namespace Cti.Stix
{
    public class Vocabulary
    {
        public static Dictionary<string, bool> Account
        {
            get => new()
            {
                { "facebook", true },
                { "ldap", true },
                { "nis", true },
                { "openid", true },
                { "radius", true },
                { "skype", true },
                { "tacacs", true },
                { "twitter", true },
                { "unix", true },
                { "windows-local", true },
                { "windows-domain", true }
            };
        }

        public static Dictionary<string, bool> AttackMotivation
        {
            get => new()
            {
                { "accidental", true },
                { "coercion", true },
                { "dominance", true },
                { "ideology", true },
                { "notoriety", true },
                { "organizational-gain", true },
                { "personal-gain", true },
                { "personal-satisfaction", true },
                { "revenge", true },
                { "unpredictable", true }
            };
        }

        public static Dictionary<string, bool> AttackResourceLevel
        {
            get => new()
            {
                { "individual", true },
                { "club", true },
                { "contest", true },
                { "team", true },
                { "organization", true },
                { "government", true }
            };
        }

        public static Dictionary<string, bool> Encryption
        {
            get => new()
            {
                { "AES-256-GCM", true },
                { "ChaCha20-Poly1305", true },
                { "mime-type-indicated", true }
            };
        }

        public static Dictionary<string, bool> ExtensionTypes
        {
            get => new()
            {
                { "new-sdo", true },
                { "new-sco", true },
                { "new-sro", true },
                { "property-extension", true },
                { "toplevel-property-extension", true }
            };
        }

        public static Dictionary<string, bool> Grouping
        {
            get => new()
            {
                { "suspicious-activity", true },
                { "malware-analysis", true },
                { "unspecified", true }
            };
        }

        public static Dictionary<string, bool> HashingAlgorithm
        {
            get => new()
            {
                { "MD5", true },
                { "SHA-1", true },
                { "SHA-256", true },
                { "SHA-512", true },
                { "SHA3-256", true },
                { "SHA3-512", true },
                { "SSDEEP", true },
                { "TLSH", true }
            };
        }

        public static Dictionary<string, bool> IdentityClass
        {
            get => new()
            {
                { "individual", true },
                { "group", true },
                { "system", true },
                { "organization", true },
                { "class", true },
                { "unknown", true }
            };
        }

        public static Dictionary<string, bool> ImplementationLanguage
        {
            get => new()
            {
                { "applescript", true },
                { "bash", true },
                { "c", true },
                { "c++", true },
                { "c#", true },
                { "go", true },
                { "java", true },
                { "javascript", true },
                { "lua", true },
                { "objective-c", true },
                { "perl", true },
                { "php", true },
                { "powershell", true },
                { "python", true },
                { "ruby", true },
                { "scala", true },
                { "swift", true },
                { "typescript", true },
                { "visual-basic", true },
                { "x86-32", true },
                { "x86-64", true }
            };
        }

        public static Dictionary<string, bool> IndicatorType
        {
            get => new()
            {
                { "anomalous-activity", true },
                { "anonymization", true },
                { "benign", true },
                { "compromised", true },
                { "malicious-activity", true },
                { "attribution", true },
                { "unknown", true }
            };
        }

        public static Dictionary<string, bool> IndustrySector
        {
            get => new()
            {
                { "agriculture", true },
                { "aerospace", true },
                { "automotive", true },
                { "chemical", true },
                { "commercial", true },
                { "communications", true },
                { "construction", true },
                { "defense", true },
                { "education", true },
                { "energy", true },
                { "entertainment", true },
                { "financial-services", true },
                { "government", true },
                { "government-emergency-services", true },
                { "government-local", true },
                { "government-national", true },
                { "government-public-services", true },
                { "government-regional", true },
                { "healthcare", true },
                { "hospitality-leisure", true },
                { "infrastructure", true },
                { "infrastructure-dams", true },
                { "infrastructure-nuclear", true },
                { "infrastructure-water", true },
                { "insurance", true },
                { "manufacturing", true },
                { "mining", true },
                { "non-profit", true },
                { "pharmaceuticals", true },
                { "retail", true },
                { "technology", true },
                { "telecommunications", true },
                { "transportation", true },
                { "utilities", true }
            };
        }

        public static Dictionary<string, bool> InfrastructureType
        {
            get => new()
            {
                { "amplification", true },
                { "anonymization", true },
                { "botnet", true },
                { "command-and-control", true },
                { "control-system", true },
                { "exfiltration", true },
                { "firewall", true },
                { "hosting-malware", true },
                { "hosting-target-lists", true },
                { "phishing", true },
                { "reconnaissance", true },
                { "routers-switches", true },
                { "staging", true },
                { "workstation", true },
                { "unknown", true }
            };
        }

        public static Dictionary<string, bool> MalwareAVResults
        {
            get => new()
            {
                { "malicious", true },
                { "suspicious", true },
                { "benign", true },
                { "unknown", true }
            };
        }

        public static Dictionary<string, bool> MalwareCapabilities
        {
            get => new()
            {
                { "accesses-remote-machines", true },
                { "anti-debugging", true },
                { "anti-disassembly", true },
                { "anti-emulation", true },
                { "anti-memory-forensics", true },
                { "anti-sandbox", true },
                { "anti-vm", true },
                { "captures-input-peripherals", true },
                { "captures-output-peripherals", true },
                { "captures-system-state-data", true },
                { "cleans-traces-of-infection", true },
                { "commits-fraud", true },
                { "communicates-with-c2", true },
                { "compromises-data-availability", true },
                { "compromises-data-integrity", true },
                { "compromises-system-availability", true },
                { "controls-local-machine", true },
                { "degrades-security-software", true },
                { "degrades-system-updates", true },
                { "determines-c2-server", true },
                { "emails-spam", true },
                { "escalates-privileges", true },
                { "evades-av", true },
                { "exfiltrates-data", true },
                { "fingerprints-host", true },
                { "hides-artifacts", true },
                { "hides-executing-code", true },
                { "infects-files", true },
                { "infects-remote-machines", true },
                { "installs-other-components", true },
                { "persists-after-system-reboot", true },
                { "prevents-artifact-access", true },
                { "prevents-artifact-deletion", true },
                { "probes-network-environment", true },
                { "self-modifies", true },
                { "steals-authentication-credentials", true },
                { "violates-system-operational-integrity", true }
            };
        }

        public static Dictionary<string, bool> MalwareType
        {
            get => new()
            {
                { "adware", true },
                { "backdoor", true },
                { "bot", true },
                { "bootkit", true },
                { "ddos", true },
                { "downloader", true },
                { "dropper", true },
                { "exploit-kit", true },
                { "keylogger", true },
                { "ransomware", true },
                { "remote-access-trojan", true },
                { "resource-exploitation", true },
                { "rogue-security-software", true },
                { "rootkit", true },
                { "screen-capture", true },
                { "spyware", true },
                { "trojan", true },
                { "unknown", true },
                { "virus", true },
                { "webshell", true },
                { "wiper", true },
                { "worm", true }
            };
        }

        public static Dictionary<string, bool> NetworkSocketAddressFamily
        {
            get => new()
            {
                { "AF_UNSPEC", true },
                { "AF_INET", true },
                { "AF_IPX", true },
                { "AF_APPLETALK", true },
                { "AF_NETBIOS", true },
                { "AF_INET6", true },
                { "AF_IRDA", true },
                { "AF_BTH", true }
            };
        }

        public static Dictionary<string, bool> NetworkSocketType
        {
            get => new()
            {
                { "SOCK_STREAM", true },
                { "SOC_DGRAM", true },
                { "SOCK_RAW", true },
                { "SOCK_RDM", true },
                { "SOCK_SEQPACKET", true }
            };
        }

        public static Dictionary<string, bool> Opinion
        {
            get => new()
            {
                { "strongly-disagree", true },
                { "disagree", true },
                { "neutral", true },
                { "agree", true },
                { "strongly-agree", true }
            };
        }

        public static Dictionary<string, bool> PatternType
        {
            get => new()
            {
                { "stix", true },
                { "pcre", true },
                { "sigma", true },
                { "snort", true },
                { "suricata", true },
                { "yara", true }
            };
        }

        public static Dictionary<string, bool> ProcessorArchitecture
        {
            get => new()
            {
                { "alpha", true },
                { "arm", true },
                { "ia-64", true },
                { "mips", true },
                { "powerpc", true },
                { "sparc", true },
                { "x86", true },
                { "x86-64", true }
            };
        }

        public static Dictionary<string, bool> Region
        {
            get => new()
            {
                { "africa", true },
                { "eastern-africa", true },
                { "middle-africa", true },
                { "northern-africa", true },
                { "southern-africa", true },
                { "western-africa", true },
                { "americas", true },
                { "caribbean", true },
                { "central-america", true },
                { "latin-america-caribbean", true },
                { "northern-america", true },
                { "south-america", true },
                { "asia", true },
                { "central-asia", true },
                { "eastern-asia", true },
                { "southern-asia", true },
                { "south-eastern-asia", true },
                { "western-asia", true },
                { "europe", true },
                { "eastern-europe", true },
                { "northern-europe", true },
                { "southern-europe", true },
                { "western-europe", true },
                { "oceania", true },
                { "antarctica", true },
                { "australia-new-zealand", true },
                { "melanesia", true },
                { "micronesia", true },
                { "polynesia", true }
            };
        }

        public static Dictionary<string, bool> ReportType
        {
            get => new()
            {
                { "attack-pattern", true },
                { "campaign", true },
                { "identity", true },
                { "indicator", true },
                { "intrusion-set", true },
                { "malware", true },
                { "observed-data", true },
                { "threat-actor", true },
                { "threat-report", true },
                { "tool", true },
                { "vulnerability", true }
            };
        }

        public static Dictionary<string, bool> ThreatActorType
        {
            get => new()
            {
                { "activist", true },
                { "competitor", true },
                { "crime-syndicate", true },
                { "criminal", true },
                { "hacker", true },
                { "insider-accidental", true },
                { "insider-disgruntled", true },
                { "nation-state", true },
                { "sensationalist", true },
                { "spy", true },
                { "terrorist", true },
                { "unknown", true }
            };
        }

        public static Dictionary<string, bool> ThreatActorRole
        {
            get => new()
            {
                { "agent", true },
                { "director", true },
                { "independent", true },
                { "infrastructure-architect", true },
                { "infrastructure-operator", true },
                { "malware-author", true },
                { "sponsor", true }
            };
        }

        public static Dictionary<string, bool> ThreatActorSophistication
        {
            get => new()
            {
                { "none", true },
                { "minimal", true },
                { "intermediate", true },
                { "advanced", true },
                { "expert", true },
                { "innovator", true },
                { "strategic", true }
            };
        }

        public static Dictionary<string, bool> ToolType
        {
            get => new()
            {
                { "denial-of-service", true },
                { "exploitation", true },
                { "information-gathering", true },
                { "network-capture", true },
                { "credential-exploitation", true },
                { "remote-access", true },
                { "vulnerability-scanning", true },
                { "unknown", true }
            };
        }

        public static Dictionary<string, bool> WindowsIntegrityLevel
        {
            get => new()
            {
                { "low", true },
                { "medium", true },
                { "high", true },
                { "system", true }
            };
        }

        public static Dictionary<string, bool> WindowsPEBinary
        {
            get => new()
            {
                { "dll", true },
                { "exe", true },
                { "sys", true }
            };
        }

        public static Dictionary<string, bool> WindowsRegistryDatatype
        {
            get => new()
            {
                { "REG_NONE", true },
                { "REG_SZ", true },
                { "REG_EXPAND_SZ", true },
                { "REG_BINARY", true },
                { "REG_DWORD", true },
                { "REG_DWORD_BIG_ENDIAN", true },
                { "REG_DWORD_LITTLE_ENDIAN", true },
                { "REG_LINK", true },
                { "REG_MULTI_SZ", true },
                { "REG_RESOURCE_LIST", true },
                { "REG_FULL_RESOURCE_DESCRIPTION", true },
                { "REG_RESOURCE_REQUIREMENTS_LIST", true },
                { "REG_QWORD", true },
                { "REG_INVALID_TYPE", true }
            };
        }

        public static Dictionary<string, bool> WindowsServiceStartType
        {
            get => new()
            {
                { "SERVICE_AUTO_START", true },
                { "SERVICE_BOOT_START", true },
                { "SERVICE_DEMAND_START", true },
                { "SERVICE_DISABLED", true },
                { "SERVICE_SYSTEM_ALERT", true }
            };
        }

        public static Dictionary<string, bool> WindowsServiceType
        {
            get => new()
            {
                { "SERVICE_KERNEL_DRIVER", true },
                { "SERVICE_FILE_SYSTEM_DRIVER", true },
                { "SERVICE_WIN32_OWN_PROCESS", true },
                { "SERVICE_WIN32_SHARE_PROCESS", true }
            };
        }

        public static Dictionary<string, bool> WindowsServiceStatus
        {
            get => new()
            {
                { "SERVICE_CONTINUE_PENDING", true },
                { "SERVICE_PAUSE_PENDING", true },
                { "SERVICE_PAUSED", true },
                { "SERVICE_RUNNING", true },
                { "SERVICE_START_PENDING", true },
                { "SERVICE_STOP_PENDING", true },
                { "SERVICE_STOPPED", true }
            };
        }

        public Dictionary<string, bool> Current
        {
            get; private set;
        }
        public Vocabulary(Dictionary<string, bool> current)
        {
            Current = current;
        }
        public override string ToString()
        {
            return string.Join(", ", Current.Where(k => k.Value).Select(k => k.Key).OrderBy(k => k)).Trim();
        }
    }
}

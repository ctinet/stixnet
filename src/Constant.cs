using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cti.Stix
{
    /// <summary>
    /// Global Constants
    /// </summary>
    internal static class Constants
    {
        public const string CurrentSTIXVersion = "2.1";
        public const string CurrentTAXIIVersion = "2.1";
        public const string MEDIA_TYPE_STIX = "application/stix+json";
        public const string MEDIA_TYPE_TAXII = "application/taxii+json";
        public const string MEDIA_TYPE_STIX20 = "application/vnd.oasis.stix+json;version=2.0";
        public const string MEDIA_TYPE_TAXII20 = "application/vnd.oasis.taxii+json;version=2.0";
        public const string MEDIA_TYPE_STIX21 = "application/stix+json;version=2.1";
        public const string MEDIA_TYPE_TAXII21 = "application/taxii+json;version=2.1";
        public const string MEDIA_TYPE_JSON = "application/json";
        public const string MEDIA_TYPE_HTML = "text/html; charset=utf-8";

        public const string TimeRFC3339 = "2006-01-02T15:04:05Z07:00";
        public const string TimeRFC3339Milli = "2006-01-02T15:04:05.999Z07:00";
        public const string TimeRFC3339Micro = "2006-01-02T15:04:05.999999Z07:00";

        public const bool STRICT_TYPES = true;
        public const bool KEEP_RAW_DATA = false;
    }
}

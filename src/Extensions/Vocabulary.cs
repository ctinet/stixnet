namespace System.Linq
{
    using Cti.Stix;

    public static class VocabularyExtensions
    {
        public static Vocabulary ToVocabulary(this Dictionary<string, bool> keyValuePairs)
        {
            return new Vocabulary(keyValuePairs);
        }
    }
}

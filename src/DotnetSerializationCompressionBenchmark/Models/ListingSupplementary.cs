using System.Collections.Generic;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class ListingSupplementary
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Types { get; set; }
        public List<SupplementaryMetadata> Metadata { get; set; }
    }
}

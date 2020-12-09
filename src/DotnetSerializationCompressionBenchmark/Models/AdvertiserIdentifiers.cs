using System.Collections.Generic;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class AdvertiserIdentifiers
    {
        public int? AdvertiserId { get; set; }
        public IEnumerable<int> ContactIds { get; set; }
        public IEnumerable<string> AgentIds { get; set; }
        public IEnumerable<int> ConjunctionContactIds { get; set; }
        public IEnumerable<string> ConjunctionAgentIds { get; set; }
        public AdvertiserType AdvertiserType { get; set; }
    }
}

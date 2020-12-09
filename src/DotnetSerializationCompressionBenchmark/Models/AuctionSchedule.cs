using System;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class AuctionSchedule
    {
        public string LocationDescription { get; set; }
        public DateTime? OpeningDateTime { get; set; }
        public string Terms { get; set; }
        public string Url { get; set; }
    }
}

using System;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class SoldDetails
    {
        public int? SoldPrice { get; set; }
        public int? GovernmentRecordedSoldPrice { get; set; }
        public DateTime? SoldDate { get; set; }
        public bool CanDisplayPrice { get; set; }
        public SoldAction SoldAction { get; set; }
        public PublishSource Source { get; set; }
    }
}

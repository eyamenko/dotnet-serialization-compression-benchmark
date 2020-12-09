using System;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class RentalDetails
    {
        public RentalMethod RentalMethod { get; set; }
        public DateTime? LeasedDate { get; set; }
        public int? LeasedPrice { get; set; }
        public bool CanDisplayPrice { get; set; }
        public int? LeasedMonths { get; set; }
        public PublishSource Source { get; set; }
        public int? TermOfLeaseFrom { get; set; }
        public int? TermOfLeaseTo { get; set; }
        public int? LeaseOutgoings { get; set; }
    }
}

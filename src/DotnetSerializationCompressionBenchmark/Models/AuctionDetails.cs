using System;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class AuctionDetails
    {
        public AuctionSchedule AuctionSchedule { get; set; }
        public int? AuctionedPrice { get; set; }
        public DateTime? AuctionedDate { get; set; }
    }
}

using System;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class TenderDetails
    {
        public string TenderRecipientName { get; set; }
        public string TenderAddress { get; set; }
        public DateTime? TenderEndDate { get; set; }
    }
}

using System;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class Inspection
    {
        public DateTime? OpeningDateTime { get; set; }
        public DateTime? ClosingDateTime { get; set; }
        public string Description { get; set; }
        public InspectionRecurrence? Recurrence { get; set; }
    }
}

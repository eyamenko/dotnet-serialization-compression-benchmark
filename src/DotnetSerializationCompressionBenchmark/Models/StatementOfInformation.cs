namespace DotnetSerializationCompressionBenchmark.Models
{
    public class StatementOfInformation
    {
        public BasicPrice EstimatedPrice { get; set; }
        public ComparableData ComparableData { get; set; }
        public MedianPriceData SuburbMedianPrice { get; set; }
        public string DocumentationUrl { get; set; }
    }
}

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class MedianPriceData
    {
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public MedianPriceType? PriceType { get; set; }
        public int? MedianPrice { get; set; }
        public string Source { get; set; }
        public string SourceDateFrom { get; set; }
        public string SourceDateTo { get; set; }
        public string SourceCollectionDate { get; set; }
    }
}

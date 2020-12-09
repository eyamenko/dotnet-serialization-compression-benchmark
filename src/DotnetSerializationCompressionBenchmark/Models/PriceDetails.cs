namespace DotnetSerializationCompressionBenchmark.Models
{
    public class PriceDetails
    {
        public decimal? Price { get; set; }
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public string PricePrefix { get; set; }
        public bool CanDisplayPrice { get; set; }
        public PriceHiddenReason[] HiddenReasons { get; set; }
        public string DisplayPrice { get; set; }
        public decimal? Bond { get; set; }
        public bool? PriceReduction { get; set; }
        public GstOptionType? GstOption { get; set; }
        public PriceType? PriceType { get; set; }
        public PriceUnitType? PriceUnit { get; set; }
    }
}

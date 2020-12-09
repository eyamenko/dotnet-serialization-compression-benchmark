namespace DotnetSerializationCompressionBenchmark.Models
{
    public class SaleDetails
    {
        public SaleMethod SaleMethod { get; set; }
        public SoldDetails SoldDetails { get; set; }
        public AuctionDetails AuctionDetails { get; set; }
        public TenderDetails TenderDetails { get; set; }
        public TenantDetails TenantDetails { get; set; }
        public int? AnnualReturn { get; set; }
        public string SaleTerms { get; set; }
    }
}

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class UnitDetails
    {
        public string Name { get; set; }
        public int? Size { get; set; }
        public decimal? Price { get; set; }
        public string Notes { get; set; }
        public bool IsSoldOrLeased { get; set; }
        public OccupancyType? Occupancy { get; set; }
        public PriceUnitType PriceUnit { get; set; }
        public decimal? LeasePriceForSaleorLease { get; set; }
    }
}

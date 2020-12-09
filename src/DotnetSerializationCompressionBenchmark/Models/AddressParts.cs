namespace DotnetSerializationCompressionBenchmark.Models
{
    public class AddressParts
    {
        public string StreetNumber { get; set; }
        public string UnitNumber { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public int? SuburbId { get; set; }
        public StateAbbreviation StateAbbreviation { get; set; }
        public string Postcode { get; set; }
        public string DisplayAddress { get; set; }
        public DisplayAddressType DisplayType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public int? RelatedId { get; set; }
        public AddressParts AddressParts { get; set; }
        public AdvertiserIdentifiers AdvertiserIdentifiers { get; set; }
        public AustralianPropertyMonitorsIdentifiers ApmIdentifiers { get; set; }
        public float? Bathrooms { get; set; }
        public float? Bedrooms { get; set; }
        public string BuildingArea { get; set; }
        public decimal? BuildingAreaSqm { get; set; }
        public decimal? AreaFrom { get; set; }
        public decimal? AreaTo { get; set; }
        public float? Carspaces { get; set; }
        public ParkingType? ParkingOption { get; set; }
        public string ParkingInformation { get; set; }
        public IEnumerable<ParkingDetails> ParkingDetails { get; set; }
        public DateTime? DateAvailable { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateMinorUpdated { get; set; }
        public DateTime? DatePurged { get; set; }
        public DateTime? DateListed { get; set; }
        public string Description { get; set; }
        public int? DevProjectId { get; set; }
        public int? EnergyEfficiencyRating { get; set; }
        public IEnumerable<string> Features { get; set; }
        public List<StructuredFeature> StructuredFeatures { get; set; }
        public GeoLocation GeoLocation { get; set; }
        public string Headline { get; set; }
        public int ListingId { get; set; }
        public PropertyInspections InspectionDetails { get; set; }
        public bool IsNewDevelopment { get; set; }
        public bool IsTopSpotEligible { get; set; }
        public string LandArea { get; set; }
        public decimal? LandAreaSqm { get; set; }
        public decimal? LandAreaFrom { get; set; }
        public decimal? LandAreaTo { get; set; }
        public IEnumerable<ListingMedia> Media { get; set; }
        public Objective Objective { get; set; }
        public PriceDetails PriceDetails { get; set; }
        public PromoLevel PromoLevel { get; set; }
        public string PropertyId { get; set; }
        public IEnumerable<PropertyType> PropertyTypes { get; set; }
        public ProviderDetails ProviderDetails { get; set; }
        public RentalDetails RentalDetails { get; set; }
        public SaleDetails SaleDetails { get; set; }
        public Status Status { get; set; }
        public ListingSaleMode SaleMode { get; set; }
        public bool? Deleted { get; set; }
        public bool IsWithdrawn { get; set; }
        public Channel Channel { get; set; }
        public Uri SeoUrl { get; set; }
        public int MapCertainty { get; set; }
        public string VirtualTourUrl { get; set; }
        public string WebLinkUrl { get; set; }
        public bool HomepassEnabled { get; set; }
        public StatementOfInformation StatementOfInformation { get; set; }
        public int? NumberOfDwellings { get; set; }
        public List<string> Highlights { get; set; }
        public bool IsRural { get; set; }
        public List<ListingSupplementary> Supplementary { get; set; }
        public EoiDetails EoiDetails { get; set; }
        public int? NumberOfOnSiteParking { get; set; }
        public OccupancyType? Occupancy { get; set; }
        public int? UnitsOffered { get; set; }
        public string PropertyName { get; set; }
        public string PropertyLocation { get; set; }
        public BuildingType? BuildingType { get; set; }
        public bool? IsSingleProperty { get; set; }
        public decimal? Nabers { get; set; }
        public List<EnquiryContactPreference> EnquiryContactPreference { get; set; }
        public List<PdfUpload> Pdfs { get; set; }
        public DateTime? SoldLeasedExpiry { get; set; }
        public List<UnitDetails> UnitDetails { get; set; }
        public List<string> Tags { get; set; }
    }
}

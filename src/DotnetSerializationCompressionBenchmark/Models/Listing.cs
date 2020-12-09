using System;
using System.Collections.Generic;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class Listing
    {
        public readonly static Listing Sample = new Listing
        {
            AddressParts = new AddressParts
            {
                DisplayAddress = "1/1 George Street, Sydney, NSW 2000",
                DisplayType = DisplayAddressType.StreetAndSuburb,
                Postcode = "2000",
                StateAbbreviation = StateAbbreviation.NSW,
                Street = "George Street",
                StreetNumber = "1",
                Suburb = "Sydney",
                SuburbId = 12345,
                UnitNumber = "1",
            },
            AdvertiserIdentifiers = new AdvertiserIdentifiers
            {
                AdvertiserId = 12345,
                AdvertiserType = AdvertiserType.Agency,
                AgentIds = new List<string>
                {
                    "12345"
                },
                ConjunctionAgentIds = new List<string>
                {
                    "12345"
                },
                ConjunctionContactIds = new List<int>
                {
                    12345
                },
                ContactIds = new List<int>
                {
                    12345
                },
            },
            ApmIdentifiers = new AustralianPropertyMonitorsIdentifiers
            {
                AddressId = 12345,
                CadastreId = 12345,
                FlatNumber = "1",
                PostcodeId = 12345,
                PropertyTypeCategoryId = 12345,
                PropertyTypeId = 12345,
                State = "NSW",
                StateId = 12345,
                StreetId = 12345,
                StreetNumber = "1",
                SuburbId = 12345,
            },
            AreaFrom = 100,
            AreaTo = 1000,
            Bathrooms = 1,
            Bedrooms = 1,
            BuildingArea = "1000 sqm",
            BuildingAreaSqm = 1000,
            BuildingType = Models.BuildingType.Whole,
            Carspaces = 1,
            Channel = Channel.Commercial,
            DateAvailable = new DateTime(2021, 01, 01),
            DateCreated = new DateTime(2021, 01, 01),
            DateListed = new DateTime(2021, 01, 01),
            DateMinorUpdated = new DateTime(2021, 01, 01),
            DatePurged = new DateTime(2021, 01, 01),
            DateUpdated = new DateTime(2021, 01, 01),
            Deleted = false,
            Description = "Test description",
            DevProjectId = 12345,
            EnergyEfficiencyRating = 5,
            EnquiryContactPreference = new List<EnquiryContactPreference>
            {
                Models.EnquiryContactPreference.ByEmail | Models.EnquiryContactPreference.ByPhone
            },
            EoiDetails = new EoiDetails
            {
                Address = "1/1 George Street, Sydney, NSW 2000",
                EndDate = new DateTime(2021, 01, 01),
                RecipientName = "John Doe",
            },
            Features = new List<string>
            {
                "AC",
                "Swimming pool",
            },
            GeoLocation = new GeoLocation
            {
                Latitude = 123456789.12345,
                Longitude = 123456789.12345,
            },
            Headline = "Test headline",
            Highlights = new List<string>
            {
                "AC",
                "Swimming pool",
            },
            HomepassEnabled = true,
            Id = 12345,
            InspectionDetails = new PropertyInspections
            {
                Inspections = new List<Inspection>
                {
                    new Inspection
                    {
                        ClosingDateTime = new DateTime(2021, 01, 01, 17, 0, 0),
                        Description = "Test description",
                        OpeningDateTime = new DateTime(2021, 01, 01, 18, 0, 0),
                        Recurrence = InspectionRecurrence.Weekly,
                    },
                },
                IsByAppointmentOnly = false,
                PastInspections = new List<Inspection>
                {
                    new Inspection
                    {
                        ClosingDateTime = new DateTime(2020, 12, 30, 17, 0, 0),
                        Description = "Test description",
                        OpeningDateTime = new DateTime(2020, 12, 30, 18, 0, 0),
                        Recurrence = InspectionRecurrence.Weekly,
                    },
                },
            },
            IsNewDevelopment = false,
            IsRural = false,
            IsSingleProperty = true,
            IsTopSpotEligible = true,
            IsWithdrawn = false,
            LandArea = "0 sqm",
            LandAreaFrom = 0.0m,
            LandAreaSqm = null,
            LandAreaTo = 0.0m,
            ListingId = 12345,
            MapCertainty = 5,
            Media = new List<ListingMedia>
            {
                new ListingMedia
                {
                    Category = ListingMediaCategory.Image,
                    Type = ListingMediaType.Photo,
                    Url = "https://google.com/1.jpg",
                },
            },
            Nabers = 4.5m,
            NumberOfDwellings = 5,
            NumberOfOnSiteParking = 99,
            Objective = Objective.Sale,
            Occupancy = OccupancyType.Vacant,
            ParkingDetails = new List<ParkingDetails>
            {
                new ParkingDetails
                {
                    NumberOfSpaces = 99,
                    ParkingType = ParkingType.OnSite,
                },
            },
            ParkingInformation = "99 on-site car spaces",
            ParkingOption = ParkingType.OnSite,
            Pdfs = new List<PdfUpload>
            {
                new PdfUpload
                {
                    FileDescription = "SOI",
                    Filename = "soi.pdf",
                    Type = PdfType.CommercialPdf,
                    Url = "https://google.com/soi.pdf",
                },
            },
            PriceDetails = new PriceDetails
            {
                Bond = 12345.123m,
                CanDisplayPrice = true,
                DisplayPrice = "$999,999.00",
                GstOption = GstOptionType.Inc,
                HiddenReasons = new[] { PriceHiddenReason.ByAgency },
                Price = 999999.00m,
                PriceFrom = 999999,
                PricePrefix = "Contact agent",
                PriceReduction = true,
                PriceTo = 999999,
                PriceType = PriceType.Gross,
                PriceUnit = PriceUnitType.TotalAmount,
            },
            PromoLevel = PromoLevel.ElitePp,
            PropertyId = "12345",
            PropertyLocation = "Test property location",
            PropertyName = "Test property name",
            PropertyTypes = new List<PropertyType>
            {
                PropertyType.Carspace,
                PropertyType.House,
            },
            ProviderDetails = new ProviderDetails
            {
                ProviderAdID = "12345",
                ProviderSystem = "test-provider-system",
            },
            RelatedId = null,
            RentalDetails = new RentalDetails
            {
                CanDisplayPrice = true,
                LeasedDate = new DateTime(2021, 01, 01),
                LeasedMonths = 12,
                LeasedPrice = 999,
                LeaseOutgoings = 999,
                RentalMethod = RentalMethod.Lease,
                Source = PublishSource.External,
                TermOfLeaseFrom = 12,
                TermOfLeaseTo = 12,
            },
            SaleDetails = new SaleDetails
            {
                AnnualReturn = 99999,
                AuctionDetails = new AuctionDetails
                {
                    AuctionedDate = new DateTime(2021, 01, 01),
                    AuctionedPrice = 999999,
                    AuctionSchedule = new AuctionSchedule
                    {
                        LocationDescription = "Test location description",
                        OpeningDateTime = new DateTime(2021, 01, 01, 14, 30, 00),
                        Terms = "Test terms",
                        Url = "https://google.com",
                    },
                },
                SaleMethod = SaleMethod.Auction,
                SaleTerms = "Test sale terms",
                SoldDetails = new SoldDetails
                {
                    CanDisplayPrice = true,
                    GovernmentRecordedSoldPrice = 899999,
                    SoldAction = SoldAction.Auction,
                    SoldDate = new DateTime(2021, 01, 01),
                    SoldPrice = 899999,
                    Source = PublishSource.External,
                },
                TenantDetails = new TenantDetails
                {
                    LeaseDateVariable = true,
                    LeaseEndDate = new DateTime(2021, 01, 01),
                    LeaseOptions = "Test lease options",
                    LeaseStartDate = new DateTime(2021, 01, 01),
                    TenantInfoTermOfLeaseFrom = 12,
                    TenantInfoTermOfLeaseTo = 12,
                    TenantName = "Test tenant name",
                    TenantRentDetails = "Test tenant rent details",
                },
                TenderDetails = new TenderDetails
                {
                    TenderAddress = "Test tender address",
                    TenderEndDate = new DateTime(2021, 01, 01),
                    TenderRecipientName = "Test recipient name",
                },
            },
            SaleMode = ListingSaleMode.Rent,
            SeoUrl = new Uri("https://google.com"),
            SoldLeasedExpiry = new DateTime(2021, 01, 01),
            StatementOfInformation = new StatementOfInformation
            {
                ComparableData = new ComparableData
                {
                    ComparableProperty = new List<PastSaleData>
                    {
                        new PastSaleData
                        {
                            DateOfSale = "01/01/2020",
                            Postcode = "2000",
                            SoldPrice = 999999,
                            State = "NSW",
                            Street = "George Street",
                            StreetNumber = "1",
                            Suburb = "Sydney",
                            UnitNumber = "1",
                        },
                    },
                    DeclarationText = "Test declaration text",
                },
                DocumentationUrl = "https://google.com/soi.pdf",
                EstimatedPrice = new BasicPrice
                {
                    From = 999999,
                    To = 999999,
                },
                SuburbMedianPrice = new MedianPriceData
                {
                    MedianPrice = 999999,
                    Postcode = "2000",
                    PriceType = MedianPriceType.House,
                    Source = "Test source",
                    SourceCollectionDate = "01/01/2020",
                    SourceDateFrom = "01/01/2020",
                    SourceDateTo = "01/01/2020",
                    Suburb = "Sydney",
                },
            },
            Status = Status.UnderOffer,
            StructuredFeatures = new List<StructuredFeature>
            {
                new StructuredFeature
                {
                    Category = "Test category",
                    Name = "Test name",
                    Source = FeatureSource.Suggested,
                },
            },
            Supplementary = new List<ListingSupplementary>
            {
                new ListingSupplementary
                {
                    Description = "Test description",
                    Metadata = new List<SupplementaryMetadata>
                    {
                        new SupplementaryMetadata
                        {
                            Description = "Test description",
                            Measurement = 1000,
                            MeasurementUnit = MeasurementUnit.SquareMetres,
                            Name = "Test name",
                        },
                    },
                    Name = "Test name",
                    Types = new List<string>
                    {
                        "Test type",
                    },
                },
            },
            Tags = new List<string>
            {
                "Test tag",
            },
            UnitDetails = new List<UnitDetails>
            {
                new UnitDetails
                {
                    IsSoldOrLeased = true,
                    LeasePriceForSaleorLease = 999.99m,
                    Name = "Test name",
                    Notes = "Test notes",
                    Occupancy = OccupancyType.Vacant,
                    Price = 999999.99m,
                    PriceUnit = PriceUnitType.TotalAmount,
                    Size = 99,
                },
            },
            UnitsOffered = 99,
            VirtualTourUrl = "https://google.com",
            WebLinkUrl = "https://google.com",
        };

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

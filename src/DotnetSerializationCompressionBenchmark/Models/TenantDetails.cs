using System;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class TenantDetails
    {
        public bool? LeaseDateVariable { get; set; }
        public string LeaseOptions { get; set; }
        public int? TenantInfoTermOfLeaseFrom { get; set; }
        public int? TenantInfoTermOfLeaseTo { get; set; }
        public string TenantName { get; set; }
        public string TenantRentDetails { get; set; }
        public DateTime? LeaseStartDate { get; set; }
        public DateTime? LeaseEndDate { get; set; }
    }
}

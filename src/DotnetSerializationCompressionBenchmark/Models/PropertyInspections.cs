using System.Collections.Generic;

namespace DotnetSerializationCompressionBenchmark.Models
{
    public class PropertyInspections
    {
        public IEnumerable<Inspection> Inspections { get; set; }
        public IEnumerable<Inspection> PastInspections { get; set; }
        public bool IsByAppointmentOnly { get; set; }
    }
}

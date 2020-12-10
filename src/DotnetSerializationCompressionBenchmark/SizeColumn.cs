using System;
using System.Linq;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using DotnetSerializationCompressionBenchmark.Processors;

namespace DotnetSerializationCompressionBenchmark
{
    public class SizeColumn : IColumn
    {
        public string Id => "Size";
        public string ColumnName => "Size";
        public bool AlwaysShow => true;
        public ColumnCategory Category => ColumnCategory.Custom;
        public int PriorityInCategory => 0;
        public bool IsNumeric => true;
        public UnitType UnitType => UnitType.Size;
        public string Legend => "Size in bytes";

        public string GetValue(Summary summary, BenchmarkCase benchmarkCase)
        {
            var categories = benchmarkCase.Descriptor.Categories;

            if (categories.Length == 1 && Enum.TryParse<ProcessorType>(categories.First(), true, out var processorType))
            {
                return ProcessorFactory.Listing[processorType].SizeBytes.ToString();
            }

            return string.Empty;
        }

        public string GetValue(Summary summary, BenchmarkCase benchmarkCase, SummaryStyle style) => GetValue(summary, benchmarkCase);

        public bool IsAvailable(Summary summary) => true;

        public bool IsDefault(Summary summary, BenchmarkCase benchmarkCase) => false;
    }
}

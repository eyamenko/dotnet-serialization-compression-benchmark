using System;
using System.Linq;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using DotnetSerializationCompressionBenchmark.Processors;

namespace DotnetSerializationCompressionBenchmark
{
    public class SizeRatioColumn : IColumn
    {
        public string Id => "SizeRatio";
        public string ColumnName => "SizeRatio";
        public bool AlwaysShow => true;
        public ColumnCategory Category => ColumnCategory.Custom;
        public int PriorityInCategory => 0;
        public bool IsNumeric => true;
        public UnitType UnitType => UnitType.Size;
        public string Legend => "Size ratio";

        public string GetValue(Summary summary, BenchmarkCase benchmarkCase)
        {
            var baseline = summary.BenchmarksCases.Single(summary.IsBaseline);

            if (!Enum.TryParse<ProcessorType>(baseline.Descriptor.Categories.First(), out var baselineProcessorType))
            {
                return string.Empty;
            }

            if (!Enum.TryParse<ProcessorType>(benchmarkCase.Descriptor.Categories.First(), out var currentProcessorType))
            {
                return string.Empty;
            }

            return (1.0 * ProcessorFactory.Instance[currentProcessorType].SizeBytes / ProcessorFactory.Instance[baselineProcessorType].SizeBytes).ToString("F2");
        }

        public string GetValue(Summary summary, BenchmarkCase benchmarkCase, SummaryStyle style) => GetValue(summary, benchmarkCase);

        public bool IsAvailable(Summary summary) => true;

        public bool IsDefault(Summary summary, BenchmarkCase benchmarkCase) => false;
    }
}

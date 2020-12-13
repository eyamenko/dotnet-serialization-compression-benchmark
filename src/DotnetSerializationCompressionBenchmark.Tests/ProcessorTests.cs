using System.Collections.Generic;
using System.Linq;
using DotnetSerializationCompressionBenchmark.Contracts;
using DotnetSerializationCompressionBenchmark.Models;
using DotnetSerializationCompressionBenchmark.Processors;
using FluentAssertions;
using Xunit;

namespace DotnetSerializationCompressionBenchmark.Tests
{
    public class ProcessorTests
    {
        public static IEnumerable<object[]> TestProcessors => ProcessorFactory.Instance.All().Select(p => new[] { p });

        [Theory]
        [MemberData(nameof(TestProcessors))]
        public void Processor_should_handle_complex_objects_out_of_the_box(IProcessorWrapper<Listing> processor)
        {
            var processedListing = processor.Unprocess();

            processedListing.Should().BeEquivalentTo(processor.Item);
        }
    }
}

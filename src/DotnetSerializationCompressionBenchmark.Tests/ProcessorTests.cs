using System.Collections.Generic;
using DotnetSerializationCompressionBenchmark.Contracts;
using DotnetSerializationCompressionBenchmark.Models;
using DotnetSerializationCompressionBenchmark.Processors;
using FluentAssertions;
using Xunit;

namespace DotnetSerializationCompressionBenchmark.Tests
{
    public class ProcessorTests
    {
        public static IEnumerable<object[]> TestProcessors => new object[][]
        {
            new[] { ProcessorFactory.MsgPackCli },
            new[] { ProcessorFactory.NewtonsoftJson },
            new[] { ProcessorFactory.SystemTextJson },
            new[] { ProcessorFactory.Utf8Json },
            new[] { ProcessorFactory.DeflateStreamMsgPackCli },
            new[] { ProcessorFactory.DeflateStreamNewtonsoftJson },
            new[] { ProcessorFactory.DeflateStreamSystemTextJson },
            new[] { ProcessorFactory.DeflateStreamUtf8Json },
            new[] { ProcessorFactory.LZ4MsgPackCli },
            new[] { ProcessorFactory.LZ4NewtonsoftJson },
            new[] { ProcessorFactory.LZ4SystemTextJson },
            new[] { ProcessorFactory.LZ4Utf8Json },
        };

        [Theory]
        [MemberData(nameof(TestProcessors))]
        public void Process_and_unprocess_should_handle_complex_objects(IProcessor processor)
        {
            var processedListing = processor.Unprocess<Listing>(processor.Process(Listing.Sample));

            processedListing.Should().BeEquivalentTo(Listing.Sample);
        }
    }
}

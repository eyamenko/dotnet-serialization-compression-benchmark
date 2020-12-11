using BenchmarkDotNet.Attributes;
using DotnetSerializationCompressionBenchmark.Models;
using DotnetSerializationCompressionBenchmark.Processors;

namespace DotnetSerializationCompressionBenchmark
{
    public class DeserializationDecompressionBenchmark
    {
        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.MsgPackCli))]
        public Listing MsgPackCli() => ProcessorFactory.Listing[ProcessorType.MsgPackCli].Unprocess();

        [Benchmark(Baseline = true)]
        [BenchmarkCategory(nameof(ProcessorType.NewtonsoftJson))]
        public Listing NewtonsoftJson() => ProcessorFactory.Listing[ProcessorType.NewtonsoftJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.SystemTextJson))]
        public Listing SystemTextJson() => ProcessorFactory.Listing[ProcessorType.SystemTextJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.Utf8Json))]
        public Listing Utf8Json() => ProcessorFactory.Listing[ProcessorType.Utf8Json].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamMsgPackCli))]
        public Listing DeflateStreamMsgPackCli() => ProcessorFactory.Listing[ProcessorType.DeflateStreamMsgPackCli].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamNewtonsoftJson))]
        public Listing DeflateStreamNewtonsoftJson() => ProcessorFactory.Listing[ProcessorType.DeflateStreamNewtonsoftJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamSystemTextJson))]
        public Listing DeflateStreamSystemTextJson() => ProcessorFactory.Listing[ProcessorType.DeflateStreamSystemTextJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamUtf8Json))]
        public Listing DeflateStreamUtf8Json() => ProcessorFactory.Listing[ProcessorType.DeflateStreamUtf8Json].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4MsgPackCli))]
        public Listing LZ4MsgPackCli() => ProcessorFactory.Listing[ProcessorType.LZ4MsgPackCli].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4NewtonsoftJson))]
        public Listing LZ4NewtonsoftJson() => ProcessorFactory.Listing[ProcessorType.LZ4NewtonsoftJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4SystemTextJson))]
        public Listing LZ4SystemTextJson() => ProcessorFactory.Listing[ProcessorType.LZ4SystemTextJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4Utf8Json))]
        public Listing LZ4Utf8Json() => ProcessorFactory.Listing[ProcessorType.LZ4Utf8Json].Unprocess();
    }
}

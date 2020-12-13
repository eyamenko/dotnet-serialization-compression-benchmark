using BenchmarkDotNet.Attributes;
using DotnetSerializationCompressionBenchmark.Models;
using DotnetSerializationCompressionBenchmark.Processors;

namespace DotnetSerializationCompressionBenchmark
{
    public class DeserializationDecompressionBenchmark
    {
        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.MessagePack))]
        public Listing MessagePack() => ProcessorFactory.Instance[ProcessorType.MessagePack].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.MsgPackCli))]
        public Listing MsgPackCli() => ProcessorFactory.Instance[ProcessorType.MsgPackCli].Unprocess();

        [Benchmark(Baseline = true)]
        [BenchmarkCategory(nameof(ProcessorType.NewtonsoftJson))]
        public Listing NewtonsoftJson() => ProcessorFactory.Instance[ProcessorType.NewtonsoftJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.SystemTextJson))]
        public Listing SystemTextJson() => ProcessorFactory.Instance[ProcessorType.SystemTextJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.Utf8Json))]
        public Listing Utf8Json() => ProcessorFactory.Instance[ProcessorType.Utf8Json].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamMessagePack))]
        public Listing DeflateStreamMessagePack() => ProcessorFactory.Instance[ProcessorType.DeflateStreamMessagePack].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamMsgPackCli))]
        public Listing DeflateStreamMsgPackCli() => ProcessorFactory.Instance[ProcessorType.DeflateStreamMsgPackCli].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamNewtonsoftJson))]
        public Listing DeflateStreamNewtonsoftJson() => ProcessorFactory.Instance[ProcessorType.DeflateStreamNewtonsoftJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamSystemTextJson))]
        public Listing DeflateStreamSystemTextJson() => ProcessorFactory.Instance[ProcessorType.DeflateStreamSystemTextJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamUtf8Json))]
        public Listing DeflateStreamUtf8Json() => ProcessorFactory.Instance[ProcessorType.DeflateStreamUtf8Json].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4MessagePack))]
        public Listing LZ4MessagePack() => ProcessorFactory.Instance[ProcessorType.LZ4MessagePack].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4MsgPackCli))]
        public Listing LZ4MsgPackCli() => ProcessorFactory.Instance[ProcessorType.LZ4MsgPackCli].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4NewtonsoftJson))]
        public Listing LZ4NewtonsoftJson() => ProcessorFactory.Instance[ProcessorType.LZ4NewtonsoftJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4SystemTextJson))]
        public Listing LZ4SystemTextJson() => ProcessorFactory.Instance[ProcessorType.LZ4SystemTextJson].Unprocess();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4Utf8Json))]
        public Listing LZ4Utf8Json() => ProcessorFactory.Instance[ProcessorType.LZ4Utf8Json].Unprocess();
    }
}

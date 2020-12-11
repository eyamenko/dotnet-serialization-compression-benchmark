using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using DotnetSerializationCompressionBenchmark.Processors;

namespace DotnetSerializationCompressionBenchmark
{
    [Config(typeof(Config))]
    public class SerializationCompressionBenchmark
    {
        private class Config : ManualConfig
        {
            public Config()
            {
                AddColumn(new SizeColumn());
            }
        }

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.MsgPackCli))]
        public byte[] MsgPackCli() => ProcessorFactory.Listing[ProcessorType.MsgPackCli].Process();

        [Benchmark(Baseline = true)]
        [BenchmarkCategory(nameof(ProcessorType.NewtonsoftJson))]
        public byte[] NewtonsoftJson() => ProcessorFactory.Listing[ProcessorType.NewtonsoftJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.SystemTextJson))]
        public byte[] SystemTextJson() => ProcessorFactory.Listing[ProcessorType.SystemTextJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.Utf8Json))]
        public byte[] Utf8Json() => ProcessorFactory.Listing[ProcessorType.Utf8Json].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamMsgPackCli))]
        public byte[] DeflateStreamMsgPackCli() => ProcessorFactory.Listing[ProcessorType.DeflateStreamMsgPackCli].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamNewtonsoftJson))]
        public byte[] DeflateStreamNewtonsoftJson() => ProcessorFactory.Listing[ProcessorType.DeflateStreamNewtonsoftJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamSystemTextJson))]
        public byte[] DeflateStreamSystemTextJson() => ProcessorFactory.Listing[ProcessorType.DeflateStreamSystemTextJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamUtf8Json))]
        public byte[] DeflateStreamUtf8Json() => ProcessorFactory.Listing[ProcessorType.DeflateStreamUtf8Json].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4MsgPackCli))]
        public byte[] LZ4MsgPackCli() => ProcessorFactory.Listing[ProcessorType.LZ4MsgPackCli].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4NewtonsoftJson))]
        public byte[] LZ4NewtonsoftJson() => ProcessorFactory.Listing[ProcessorType.LZ4NewtonsoftJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4SystemTextJson))]
        public byte[] LZ4SystemTextJson() => ProcessorFactory.Listing[ProcessorType.LZ4SystemTextJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4Utf8Json))]
        public byte[] LZ4Utf8Json() => ProcessorFactory.Listing[ProcessorType.LZ4Utf8Json].Process();
    }
}

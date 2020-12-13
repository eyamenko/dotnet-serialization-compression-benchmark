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
                AddColumn(new SizeRatioColumn());
            }
        }

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.MessagePack))]
        public byte[] MessagePack() => ProcessorFactory.Instance[ProcessorType.MessagePack].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.MsgPackCli))]
        public byte[] MsgPackCli() => ProcessorFactory.Instance[ProcessorType.MsgPackCli].Process();

        [Benchmark(Baseline = true)]
        [BenchmarkCategory(nameof(ProcessorType.NewtonsoftJson))]
        public byte[] NewtonsoftJson() => ProcessorFactory.Instance[ProcessorType.NewtonsoftJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.SystemTextJson))]
        public byte[] SystemTextJson() => ProcessorFactory.Instance[ProcessorType.SystemTextJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.Utf8Json))]
        public byte[] Utf8Json() => ProcessorFactory.Instance[ProcessorType.Utf8Json].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamMessagePack))]
        public byte[] DeflateStreamMessagePack() => ProcessorFactory.Instance[ProcessorType.DeflateStreamMessagePack].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamMsgPackCli))]
        public byte[] DeflateStreamMsgPackCli() => ProcessorFactory.Instance[ProcessorType.DeflateStreamMsgPackCli].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamNewtonsoftJson))]
        public byte[] DeflateStreamNewtonsoftJson() => ProcessorFactory.Instance[ProcessorType.DeflateStreamNewtonsoftJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamSystemTextJson))]
        public byte[] DeflateStreamSystemTextJson() => ProcessorFactory.Instance[ProcessorType.DeflateStreamSystemTextJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.DeflateStreamUtf8Json))]
        public byte[] DeflateStreamUtf8Json() => ProcessorFactory.Instance[ProcessorType.DeflateStreamUtf8Json].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4MessagePack))]
        public byte[] LZ4MessagePack() => ProcessorFactory.Instance[ProcessorType.LZ4MessagePack].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4MsgPackCli))]
        public byte[] LZ4MsgPackCli() => ProcessorFactory.Instance[ProcessorType.LZ4MsgPackCli].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4NewtonsoftJson))]
        public byte[] LZ4NewtonsoftJson() => ProcessorFactory.Instance[ProcessorType.LZ4NewtonsoftJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4SystemTextJson))]
        public byte[] LZ4SystemTextJson() => ProcessorFactory.Instance[ProcessorType.LZ4SystemTextJson].Process();

        [Benchmark]
        [BenchmarkCategory(nameof(ProcessorType.LZ4Utf8Json))]
        public byte[] LZ4Utf8Json() => ProcessorFactory.Instance[ProcessorType.LZ4Utf8Json].Process();
    }
}

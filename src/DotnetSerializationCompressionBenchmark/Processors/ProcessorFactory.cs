using DotnetSerializationCompressionBenchmark.Contracts;
using MessagePack;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public static class ProcessorFactory
    {
        public static readonly IProcessor BinaryFormatter = new BinaryFormatterProcessor();
        public static readonly IProcessor Jil = new JilProcessor();
        public static readonly IProcessor MessagePack = new MessagePackProcessor();
        public static readonly IProcessor MsgPackCli = new MsgPackCliProcessor();
        public static readonly IProcessor NewtonsoftJson = new NewtonsoftJsonProcessor();
        public static readonly IProcessor ProtobufNet = new ProtobufNetProcessor();
        public static readonly IProcessor SystemTextJson = new SystemTextJsonProcessor();
        public static readonly IProcessor Utf8Json = new Utf8JsonProcessor();

        /*
         * MessagePack with compression
         */
        public static readonly IProcessor MessagePackLz4Block = new MessagePackProcessor(MessagePackSerializerOptions.Standard.WithCompression(MessagePackCompression.Lz4Block));
        public static readonly IProcessor MessagePackLz4BlockArray = new MessagePackProcessor(MessagePackSerializerOptions.Standard.WithCompression(MessagePackCompression.Lz4BlockArray));

        /*
         * DeflateStream
         */
        public static readonly IProcessor DeflateStreamBinaryFormatter = new DeflateStreamProcessor(new BinaryFormatterProcessor());
        public static readonly IProcessor DeflateStreamJil = new DeflateStreamProcessor(new JilProcessor());
        public static readonly IProcessor DeflateStreamMessagePack = new DeflateStreamProcessor(new MessagePackProcessor());
        public static readonly IProcessor DeflateStreamMsgPackCli = new DeflateStreamProcessor(new MsgPackCliProcessor());
        public static readonly IProcessor DeflateStreamNewtonsoftJson = new DeflateStreamProcessor(new NewtonsoftJsonProcessor());
        public static readonly IProcessor DeflateStreamProtobufNet = new DeflateStreamProcessor(new ProtobufNetProcessor());
        public static readonly IProcessor DeflateStreamSystemTextJson = new DeflateStreamProcessor(new SystemTextJsonProcessor());
        public static readonly IProcessor DeflateStreamUtf8Json = new DeflateStreamProcessor(new Utf8JsonProcessor());

        /*
         * LZ4
         */
        public static readonly IProcessor LZ4BinaryFormatter = new LZ4Processor(new BinaryFormatterProcessor());
        public static readonly IProcessor LZ4Jil = new LZ4Processor(new JilProcessor());
        public static readonly IProcessor LZ4MessagePack = new LZ4Processor(new MessagePackProcessor());
        public static readonly IProcessor LZ4MsgPackCli = new LZ4Processor(new MsgPackCliProcessor());
        public static readonly IProcessor LZ4NewtonsoftJson = new LZ4Processor(new NewtonsoftJsonProcessor());
        public static readonly IProcessor LZ4ProtobufNet = new LZ4Processor(new ProtobufNetProcessor());
        public static readonly IProcessor LZ4SystemTextJson = new LZ4Processor(new SystemTextJsonProcessor());
        public static readonly IProcessor LZ4Utf8Json = new LZ4Processor(new Utf8JsonProcessor());
    }
}

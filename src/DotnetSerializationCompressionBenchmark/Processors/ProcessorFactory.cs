using DotnetSerializationCompressionBenchmark.Contracts;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public static class ProcessorFactory
    {
        public static readonly IProcessor MsgPackCli = new MsgPackCliProcessor();
        public static readonly IProcessor NewtonsoftJson = new NewtonsoftJsonProcessor();
        public static readonly IProcessor SystemTextJson = new SystemTextJsonProcessor();
        public static readonly IProcessor Utf8Json = new Utf8JsonProcessor();

        /*
         * DeflateStream
         */
        public static readonly IProcessor DeflateStreamMsgPackCli = new DeflateStreamProcessor(new MsgPackCliProcessor());
        public static readonly IProcessor DeflateStreamNewtonsoftJson = new DeflateStreamProcessor(new NewtonsoftJsonProcessor());
        public static readonly IProcessor DeflateStreamSystemTextJson = new DeflateStreamProcessor(new SystemTextJsonProcessor());
        public static readonly IProcessor DeflateStreamUtf8Json = new DeflateStreamProcessor(new Utf8JsonProcessor());

        /*
         * LZ4
         */
        public static readonly IProcessor LZ4MsgPackCli = new LZ4Processor(new MsgPackCliProcessor());
        public static readonly IProcessor LZ4NewtonsoftJson = new LZ4Processor(new NewtonsoftJsonProcessor());
        public static readonly IProcessor LZ4SystemTextJson = new LZ4Processor(new SystemTextJsonProcessor());
        public static readonly IProcessor LZ4Utf8Json = new LZ4Processor(new Utf8JsonProcessor());
    }
}

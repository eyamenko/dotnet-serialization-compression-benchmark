namespace DotnetSerializationCompressionBenchmark.Processors
{
    public enum ProcessorType
    {
        MsgPackCli,
        NewtonsoftJson,
        SystemTextJson,
        Utf8Json,
        DeflateStreamMsgPackCli,
        DeflateStreamNewtonsoftJson,
        DeflateStreamSystemTextJson,
        DeflateStreamUtf8Json,
        LZ4MsgPackCli,
        LZ4NewtonsoftJson,
        LZ4SystemTextJson,
        LZ4Utf8Json,
    }
}

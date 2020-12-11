namespace DotnetSerializationCompressionBenchmark.Processors
{
    public enum ProcessorType
    {
        MessagePack,
        MsgPackCli,
        NewtonsoftJson,
        SystemTextJson,
        Utf8Json,
        DeflateStreamMessagePack,
        DeflateStreamMsgPackCli,
        DeflateStreamNewtonsoftJson,
        DeflateStreamSystemTextJson,
        DeflateStreamUtf8Json,
        LZ4MessagePack,
        LZ4MsgPackCli,
        LZ4NewtonsoftJson,
        LZ4SystemTextJson,
        LZ4Utf8Json,
    }
}

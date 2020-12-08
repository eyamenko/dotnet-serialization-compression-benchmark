using DotnetSerializationCompressionBenchmark.Contracts;
using MessagePack;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class MessagePackProcessor : IProcessor
    {
        public byte[] Process<T>(T item)
        {
            return MessagePackSerializer.Serialize(item);
        }

        public T Unprocess<T>(byte[] bytes)
        {
            return MessagePackSerializer.Deserialize<T>(bytes);
        }
    }
}

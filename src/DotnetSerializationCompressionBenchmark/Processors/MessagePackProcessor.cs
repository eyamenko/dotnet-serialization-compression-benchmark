using DotnetSerializationCompressionBenchmark.Contracts;
using MessagePack;
using MessagePack.Resolvers;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class MessagePackProcessor : IProcessor
    {
        public byte[] Process<T>(T item)
        {
            return MessagePackSerializer.Serialize(item, ContractlessStandardResolver.Options);
        }

        public T Unprocess<T>(byte[] bytes)
        {
            return MessagePackSerializer.Deserialize<T>(bytes, ContractlessStandardResolver.Options);
        }
    }
}

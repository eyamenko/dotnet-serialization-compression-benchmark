using DotnetSerializationCompressionBenchmark.Contracts;
using MessagePack;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class MessagePackProcessor : IProcessor
    {
        private readonly MessagePackSerializerOptions _options;

        public MessagePackProcessor(MessagePackSerializerOptions options = null)
        {
            _options = options;
        }

        public byte[] Process<T>(T item)
        {
            return MessagePackSerializer.Serialize(item, _options);
        }

        public T Unprocess<T>(byte[] bytes)
        {
            return MessagePackSerializer.Deserialize<T>(bytes);
        }
    }
}

using System.IO;
using DotnetSerializationCompressionBenchmark.Contracts;
using ProtoBuf;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class ProtobufNetProcessor : IProcessor
    {
        public byte[] Process<T>(T item)
        {
            using var ms = new MemoryStream();

            Serializer.Serialize(ms, item);

            return ms.ToArray();
        }

        public T Unprocess<T>(byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);

            return Serializer.Deserialize<T>(ms);
        }
    }
}

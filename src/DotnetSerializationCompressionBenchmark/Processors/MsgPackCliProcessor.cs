using System.IO;
using DotnetSerializationCompressionBenchmark.Contracts;
using MsgPack.Serialization;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class MsgPackCliProcessor : IProcessor
    {
        public byte[] Process<T>(T item)
        {
            var serializer = MessagePackSerializer.Get<T>();

            using var ms = new MemoryStream();

            serializer.Pack(ms, item);

            return ms.ToArray();
        }

        public T Unprocess<T>(byte[] bytes)
        {
            var serializer = MessagePackSerializer.Get<T>();

            using var ms = new MemoryStream(bytes);

            return serializer.Unpack(ms);
        }
    }
}

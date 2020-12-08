using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DotnetSerializationCompressionBenchmark.Contracts;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class BinaryFormatterProcessor : IProcessor
    {
        private readonly BinaryFormatter _binaryFormatter;

        public BinaryFormatterProcessor()
        {
            _binaryFormatter = new BinaryFormatter();
        }

        public byte[] Process<T>(T item)
        {
            using var ms = new MemoryStream();

            _binaryFormatter.Serialize(ms, item);

            return ms.ToArray();
        }

        public T Unprocess<T>(byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);

            return (T)_binaryFormatter.Deserialize(ms);
        }
    }
}

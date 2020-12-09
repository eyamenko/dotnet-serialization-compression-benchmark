using System.IO;
using System.IO.Compression;
using DotnetSerializationCompressionBenchmark.Contracts;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class DeflateStreamProcessor : IProcessor
    {
        private readonly IProcessor _processor;

        public DeflateStreamProcessor(IProcessor processor)
        {
            _processor = processor;
        }

        public byte[] Process<T>(T item)
        {
            var bytes = _processor.Process(item);

            using var outputStream = new MemoryStream();
            using var deflateStream = new DeflateStream(outputStream, CompressionLevel.Optimal);

            deflateStream.Write(bytes, 0, bytes.Length);

            return outputStream.ToArray();
        }

        public T Unprocess<T>(byte[] bytes)
        {
            using var outputStream = new MemoryStream();
            using var inputStream = new MemoryStream(bytes);
            using var deflateStream = new DeflateStream(inputStream, CompressionMode.Decompress);

            deflateStream.CopyTo(outputStream);

            return _processor.Unprocess<T>(outputStream.ToArray());
        }
    }
}

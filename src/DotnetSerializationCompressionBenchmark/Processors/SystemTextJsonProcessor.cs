using System.Text.Json;
using DotnetSerializationCompressionBenchmark.Contracts;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class SystemTextJsonProcessor : IProcessor
    {
        public byte[] Process<T>(T item)
        {
            return JsonSerializer.SerializeToUtf8Bytes(item);
        }

        public T Unprocess<T>(byte[] bytes)
        {
            return JsonSerializer.Deserialize<T>(bytes);
        }
    }
}

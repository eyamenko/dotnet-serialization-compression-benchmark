using DotnetSerializationCompressionBenchmark.Contracts;
using Utf8Json;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class Utf8JsonProcessor : IProcessor
    {
        public byte[] Process<T>(T item)
        {
            return JsonSerializer.Serialize(item);
        }

        public T Unprocess<T>(byte[] bytes)
        {
            return JsonSerializer.Deserialize<T>(bytes);
        }
    }
}

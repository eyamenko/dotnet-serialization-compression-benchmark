using System.Text;
using DotnetSerializationCompressionBenchmark.Contracts;
using Jil;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class JilProcessor : IProcessor
    {
        public byte[] Process<T>(T item)
        {
            return Encoding.UTF8.GetBytes(JSON.Serialize(item));
        }

        public T Unprocess<T>(byte[] bytes)
        {
            return JSON.Deserialize<T>(Encoding.UTF8.GetString(bytes));
        }
    }
}

using System.Text;
using DotnetSerializationCompressionBenchmark.Contracts;
using Newtonsoft.Json;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class NewtonsoftJsonProcessor : IProcessor
    {
        public byte[] Process<T>(T item)
        {
            return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(item));
        }

        public T Unprocess<T>(byte[] bytes)
        {
            return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(bytes));
        }
    }
}

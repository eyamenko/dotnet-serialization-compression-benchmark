using BenchmarkDotNet.Running;

namespace DotnetSerializationCompressionBenchmark
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<SerializationCompressionBenchmark>();
            BenchmarkRunner.Run<DeserializationDecompressionBenchmark>();
        }
    }
}

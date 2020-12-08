namespace DotnetSerializationCompressionBenchmark.Contracts
{
    public interface IProcessor
    {
        byte[] Process<T>(T item);
        T Unprocess<T>(byte[] bytes);
    }
}

namespace DotnetSerializationCompressionBenchmark.Contracts
{
    public interface IProcessorWrapper<T>
    {
        int SizeBytes { get; }
        T Item { get; }
        byte[] Process();
        T Unprocess();
    }
}

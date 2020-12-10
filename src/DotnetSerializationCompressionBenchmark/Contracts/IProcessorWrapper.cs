namespace DotnetSerializationCompressionBenchmark.Contracts
{
    public interface IProcessorWrapper<T>
    {
        int SizeBytes { get; }
        byte[] Process();
        T Unprocess();
    }
}

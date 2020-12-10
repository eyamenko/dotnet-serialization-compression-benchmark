using System.Collections.Generic;
using DotnetSerializationCompressionBenchmark.Processors;

namespace DotnetSerializationCompressionBenchmark.Contracts
{
    public interface IProcessorFactory<T>
    {
        IProcessorWrapper<T> this[ProcessorType processorType] { get; }
        IList<IProcessorWrapper<T>> All();
    }
}

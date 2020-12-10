using System.Collections.Generic;
using System.Linq;
using DotnetSerializationCompressionBenchmark.Contracts;
using DotnetSerializationCompressionBenchmark.Models;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public static class ProcessorFactory
    {
        public static readonly IProcessorFactory<Listing> Listing = new ProcessorFactoryPrivate<Listing>(Models.Listing.Sample);

        private class ProcessorFactoryPrivate<T> : IProcessorFactory<T>
        {
            private readonly IDictionary<ProcessorType, IProcessorWrapper<T>> _processors;

            public ProcessorFactoryPrivate(T item)
            {
                _processors = new Dictionary<ProcessorType, IProcessorWrapper<T>>
                {
                    [ProcessorType.MsgPackCli] = new ProcessorWrapper<T>(new MsgPackCliProcessor(), item),
                    [ProcessorType.NewtonsoftJson] = new ProcessorWrapper<T>(new NewtonsoftJsonProcessor(), item),
                    [ProcessorType.SystemTextJson] = new ProcessorWrapper<T>(new SystemTextJsonProcessor(), item),
                    [ProcessorType.Utf8Json] = new ProcessorWrapper<T>(new Utf8JsonProcessor(), item),
                    [ProcessorType.DeflateStreamMsgPackCli] = new ProcessorWrapper<T>(new DeflateStreamProcessor(new MsgPackCliProcessor()), item),
                    [ProcessorType.DeflateStreamNewtonsoftJson] = new ProcessorWrapper<T>(new DeflateStreamProcessor(new NewtonsoftJsonProcessor()), item),
                    [ProcessorType.DeflateStreamSystemTextJson] = new ProcessorWrapper<T>(new DeflateStreamProcessor(new SystemTextJsonProcessor()), item),
                    [ProcessorType.DeflateStreamUtf8Json] = new ProcessorWrapper<T>(new DeflateStreamProcessor(new Utf8JsonProcessor()), item),
                    [ProcessorType.LZ4MsgPackCli] = new ProcessorWrapper<T>(new LZ4Processor(new MsgPackCliProcessor()), item),
                    [ProcessorType.LZ4NewtonsoftJson] = new ProcessorWrapper<T>(new LZ4Processor(new NewtonsoftJsonProcessor()), item),
                    [ProcessorType.LZ4SystemTextJson] = new ProcessorWrapper<T>(new LZ4Processor(new SystemTextJsonProcessor()), item),
                    [ProcessorType.LZ4Utf8Json] = new ProcessorWrapper<T>(new LZ4Processor(new Utf8JsonProcessor()), item),
                };
            }

            public IProcessorWrapper<T> this[ProcessorType processorType] => _processors[processorType];

            public IList<IProcessorWrapper<T>> All() => _processors.Values.ToList();
        }
    }
}

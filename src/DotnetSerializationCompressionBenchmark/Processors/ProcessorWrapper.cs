using DotnetSerializationCompressionBenchmark.Contracts;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class ProcessorWrapper<T> : IProcessorWrapper<T>
    {
        private readonly IProcessor _processor;
        private readonly T _item;
        private readonly byte[] _bytes;

        public ProcessorWrapper(IProcessor processor, T item)
        {
            _processor = processor;
            _item = item;
            _bytes = processor.Process(item);
        }

        public int SizeBytes => _bytes.Length;

        public byte[] Process() => _processor.Process(_item);

        public T Unprocess() => _processor.Unprocess<T>(_bytes);
    }
}

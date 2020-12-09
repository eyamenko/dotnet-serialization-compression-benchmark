using DotnetSerializationCompressionBenchmark.Contracts;
using K4os.Compression.LZ4;

namespace DotnetSerializationCompressionBenchmark.Processors
{
    public class LZ4Processor : IProcessor
    {
        private readonly IProcessor _processor;

        public LZ4Processor(IProcessor processor)
        {
            _processor = processor;
        }

        public byte[] Process<T>(T item)
        {
            var bytes = _processor.Process(item);

            return LZ4Pickler.Pickle(bytes);
        }

        public T Unprocess<T>(byte[] bytes)
        {
            return _processor.Unprocess<T>(LZ4Pickler.Unpickle(bytes));
        }
    }
}

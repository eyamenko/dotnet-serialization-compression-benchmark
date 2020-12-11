# Benchmark suit for popular .NET serialization and compression libraries that work without any setup

## Serialization libraries benchmarked

* [MsgPack.Cli](https://github.com/msgpack/msgpack-cli)
* [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
* [System.Text.Json](https://docs.microsoft.com/en-us/dotnet/api/system.text.json)
* [Utf8Json](https://github.com/neuecc/Utf8Json)

## Compression libraries benchmarked

* [K4os.Compression.LZ4](https://github.com/MiloszKrajewski/K4os.Compression.LZ4)
* [DeflateStream](https://docs.microsoft.com/en-us/dotnet/api/system.io.compression.deflatestream)

## No Jil, protobuf-net, etc.?

`Jil` doesn't handle all property types (e.g. `System.Uri`) and `protobuf-net` requires attributes to be used on each property.

# Benchmark suit for popular .NET serialization and compression libraries that work without any setup

## Serialization libraries benchmarked

* [MessagePack](https://github.com/neuecc/MessagePack-CSharp)
* [MsgPack.Cli](https://github.com/msgpack/msgpack-cli)
* [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
* [System.Text.Json](https://docs.microsoft.com/en-us/dotnet/api/system.text.json)
* [Utf8Json](https://github.com/neuecc/Utf8Json)

## Compression libraries benchmarked

* [K4os.Compression.LZ4](https://github.com/MiloszKrajewski/K4os.Compression.LZ4)
* [DeflateStream](https://docs.microsoft.com/en-us/dotnet/api/system.io.compression.deflatestream)

## No Jil, protobuf-net, etc.?

* `Jil` doesn't handle all types (e.g. `System.Uri`)
* `protobuf-net` doesn't work without attributes

## Serialization and compression benchmark report

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT
  DefaultJob : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT


```
|                      Method |     Mean |    Error |    StdDev |   Median | Ratio | RatioSD | Size |
|---------------------------- |---------:|---------:|----------:|---------:|------:|--------:|-----:|
|                 MessagePack | 226.6 μs | 57.48 μs | 168.58 μs | 133.4 μs |  0.93 |    0.76 | 4085 |
|                  MsgPackCli | 329.8 μs | 75.20 μs | 220.54 μs | 203.7 μs |  1.27 |    0.87 | 1616 |
|              NewtonsoftJson | 275.6 μs | 28.61 μs |  81.15 μs | 244.4 μs |  1.00 |    0.00 | 5235 |
|              SystemTextJson | 277.4 μs | 50.46 μs | 147.20 μs | 203.2 μs |  1.07 |    0.62 | 5221 |
|                    Utf8Json | 258.0 μs | 48.74 μs | 139.06 μs | 190.4 μs |  0.99 |    0.57 | 5504 |
|    DeflateStreamMessagePack | 371.7 μs | 59.78 μs | 174.38 μs | 285.9 μs |  1.49 |    0.85 | 1889 |
|     DeflateStreamMsgPackCli | 423.0 μs | 82.43 μs | 241.74 μs | 286.8 μs |  1.69 |    1.08 |  844 |
| DeflateStreamNewtonsoftJson | 414.3 μs | 29.67 μs |  84.16 μs | 393.8 μs |  1.60 |    0.44 | 1790 |
| DeflateStreamSystemTextJson | 402.1 μs | 50.43 μs | 145.50 μs | 337.7 μs |  1.54 |    0.62 | 1788 |
|       DeflateStreamUtf8Json | 424.6 μs | 62.97 μs | 183.69 μs | 329.6 μs |  1.66 |    0.85 | 1896 |
|              LZ4MessagePack | 274.8 μs | 61.36 μs | 179.96 μs | 183.8 μs |  1.11 |    0.83 | 2561 |
|               LZ4MsgPackCli | 361.0 μs | 83.46 μs | 244.78 μs | 221.7 μs |  1.45 |    1.14 | 1079 |
|           LZ4NewtonsoftJson | 324.0 μs | 32.12 μs |  91.63 μs | 297.1 μs |  1.28 |    0.53 | 2707 |
|           LZ4SystemTextJson | 307.6 μs | 49.86 μs | 142.27 μs | 243.3 μs |  1.19 |    0.62 | 2705 |
|                 LZ4Utf8Json | 314.2 μs | 53.21 μs | 153.52 μs | 251.1 μs |  1.29 |    0.80 | 2895 |

## Deserialization and decompression benchmark report

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT
  DefaultJob : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT


```
|                      Method |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |
|---------------------------- |---------:|----------:|----------:|---------:|------:|--------:|
|                 MessagePack | 221.3 μs |  32.86 μs |  94.27 μs | 183.7 μs |  0.66 |    0.21 |
|                  MsgPackCli | 515.8 μs | 133.86 μs | 394.70 μs | 277.1 μs |  1.57 |    1.15 |
|              NewtonsoftJson | 336.9 μs |  32.89 μs |  95.43 μs | 306.3 μs |  1.00 |    0.00 |
|              SystemTextJson | 293.6 μs |  42.23 μs | 121.83 μs | 244.0 μs |  0.89 |    0.34 |
|                    Utf8Json | 229.0 μs |  23.73 μs |  67.69 μs | 198.8 μs |  0.72 |    0.26 |
|    DeflateStreamMessagePack | 291.8 μs |  42.96 μs | 123.27 μs | 234.5 μs |  0.87 |    0.27 |
|     DeflateStreamMsgPackCli | 528.2 μs | 119.18 μs | 349.53 μs | 329.3 μs |  1.64 |    1.13 |
| DeflateStreamNewtonsoftJson | 393.1 μs |  33.76 μs |  97.39 μs | 366.0 μs |  1.20 |    0.25 |
| DeflateStreamSystemTextJson | 353.8 μs |  48.15 μs | 139.68 μs | 287.3 μs |  1.07 |    0.36 |
|       DeflateStreamUtf8Json | 307.5 μs |  34.47 μs | 100.55 μs | 258.0 μs |  0.97 |    0.37 |
|              LZ4MessagePack | 230.9 μs |  35.10 μs | 100.71 μs | 189.0 μs |  0.69 |    0.24 |
|               LZ4MsgPackCli | 479.5 μs | 111.80 μs | 327.90 μs | 300.8 μs |  1.45 |    0.92 |
|           LZ4NewtonsoftJson | 347.2 μs |  32.95 μs |  95.59 μs | 308.2 μs |  1.06 |    0.24 |
|           LZ4SystemTextJson | 295.5 μs |  44.91 μs | 131.00 μs | 237.4 μs |  0.91 |    0.38 |
|                 LZ4Utf8Json | 253.3 μs |  25.46 μs |  73.47 μs | 214.8 μs |  0.77 |    0.20 |

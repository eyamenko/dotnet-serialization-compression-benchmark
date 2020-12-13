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
|                      Method |     Mean |    Error |    StdDev |   Median | Ratio | RatioSD |  Size | SizeRatio |
|---------------------------- |---------:|---------:|----------:|---------:|------:|--------:|------:|----------:|
|                 MessagePack | 224.2 μs | 43.83 μs | 124.33 μs | 169.3 μs |  0.75 |    0.42 | 10950 |      0.86 |
|                  MsgPackCli | 339.1 μs | 76.21 μs | 221.11 μs | 225.4 μs |  1.13 |    0.75 |  7586 |      0.60 |
|              NewtonsoftJson | 309.8 μs | 23.44 μs |  66.12 μs | 292.9 μs |  1.00 |    0.00 | 12661 |      1.00 |
|              SystemTextJson | 277.5 μs | 35.93 μs | 100.76 μs | 238.8 μs |  0.91 |    0.32 | 12603 |      1.00 |
|                    Utf8Json | 261.6 μs | 45.95 μs | 133.32 μs | 197.3 μs |  0.90 |    0.50 | 13156 |      1.04 |
|    DeflateStreamMessagePack | 520.8 μs | 56.43 μs | 162.80 μs | 437.5 μs |  1.76 |    0.65 |  5867 |      0.46 |
|     DeflateStreamMsgPackCli | 554.4 μs | 69.63 μs | 200.89 μs | 448.8 μs |  1.79 |    0.61 |  4795 |      0.38 |
| DeflateStreamNewtonsoftJson | 605.1 μs | 24.34 μs |  68.24 μs | 585.1 μs |  2.01 |    0.35 |  5900 |      0.47 |
| DeflateStreamSystemTextJson | 570.8 μs | 48.21 μs | 138.34 μs | 509.3 μs |  1.90 |    0.49 |  5884 |      0.46 |
|       DeflateStreamUtf8Json | 558.8 μs | 47.20 μs | 135.42 μs | 500.3 μs |  1.87 |    0.52 |  6130 |      0.48 |
|              LZ4MessagePack | 326.7 μs | 55.54 μs | 160.24 μs | 246.6 μs |  1.11 |    0.59 |  8103 |      0.64 |
|               LZ4MsgPackCli | 403.7 μs | 78.45 μs | 228.85 μs | 286.7 μs |  1.37 |    0.82 |  6797 |      0.54 |
|           LZ4NewtonsoftJson | 399.5 μs | 20.68 μs |  57.99 μs | 386.0 μs |  1.32 |    0.20 |  8993 |      0.71 |
|           LZ4SystemTextJson | 355.2 μs | 41.45 μs | 116.90 μs | 304.5 μs |  1.19 |    0.43 |  8977 |      0.71 |
|                 LZ4Utf8Json | 344.0 μs | 42.99 μs | 122.67 μs | 287.5 μs |  1.14 |    0.40 |  9289 |      0.73 |

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
|                 MessagePack | 245.1 μs |  28.24 μs |  80.11 μs | 209.6 μs |  0.63 |    0.18 |
|                  MsgPackCli | 462.0 μs | 109.30 μs | 318.83 μs | 288.7 μs |  1.19 |    0.76 |
|              NewtonsoftJson | 395.5 μs |  29.25 μs |  82.50 μs | 386.9 μs |  1.00 |    0.00 |
|              SystemTextJson | 300.9 μs |  27.56 μs |  77.73 μs | 268.3 μs |  0.77 |    0.15 |
|                    Utf8Json | 221.1 μs |  19.27 μs |  54.67 μs | 201.9 μs |  0.58 |    0.19 |
|    DeflateStreamMessagePack | 336.7 μs |  34.65 μs |  98.29 μs | 297.4 μs |  0.86 |    0.16 |
|     DeflateStreamMsgPackCli | 543.2 μs | 111.26 μs | 322.80 μs | 373.2 μs |  1.40 |    0.77 |
| DeflateStreamNewtonsoftJson | 496.2 μs |  36.32 μs | 104.78 μs | 470.6 μs |  1.29 |    0.24 |
| DeflateStreamSystemTextJson | 404.8 μs |  45.14 μs | 128.05 μs | 360.4 μs |  1.04 |    0.29 |
|       DeflateStreamUtf8Json | 331.7 μs |  27.84 μs |  79.44 μs | 303.3 μs |  0.88 |    0.28 |
|              LZ4MessagePack | 248.7 μs |  31.17 μs |  87.91 μs | 218.2 μs |  0.62 |    0.15 |
|               LZ4MsgPackCli | 476.3 μs | 107.66 μs | 314.04 μs | 305.4 μs |  1.23 |    0.78 |
|           LZ4NewtonsoftJson | 408.3 μs |  31.44 μs |  90.71 μs | 398.7 μs |  1.05 |    0.16 |
|           LZ4SystemTextJson | 301.9 μs |  30.14 μs |  83.52 μs | 282.4 μs |  0.77 |    0.14 |
|                 LZ4Utf8Json | 239.5 μs |  22.86 μs |  65.59 μs | 215.5 μs |  0.63 |    0.20 |

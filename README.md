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
|                  MsgPackCli | 322.0 μs | 81.30 μs | 238.43 μs | 188.0 μs |  1.32 |    1.09 | 1616 |
|              NewtonsoftJson | 253.9 μs | 23.79 μs |  67.88 μs | 223.1 μs |  1.00 |    0.00 | 5235 |
|              SystemTextJson | 266.3 μs | 47.12 μs | 135.19 μs | 205.6 μs |  1.11 |    0.61 | 5221 |
|                    Utf8Json | 222.8 μs | 38.40 μs | 107.66 μs | 177.7 μs |  0.92 |    0.45 | 5504 |
|     DeflateStreamMsgPackCli | 404.7 μs | 80.86 μs | 235.87 μs | 278.4 μs |  1.69 |    1.10 |  844 |
| DeflateStreamNewtonsoftJson | 387.8 μs | 27.73 μs |  78.66 μs | 366.2 μs |  1.65 |    0.56 | 1790 |
| DeflateStreamSystemTextJson | 422.4 μs | 58.14 μs | 169.60 μs | 330.7 μs |  1.79 |    0.93 | 1788 |
|       DeflateStreamUtf8Json | 344.0 μs | 39.32 μs | 108.30 μs | 296.6 μs |  1.44 |    0.48 | 1896 |
|               LZ4MsgPackCli | 344.4 μs | 84.36 μs | 247.40 μs | 212.9 μs |  1.41 |    1.13 | 1079 |
|           LZ4NewtonsoftJson | 288.5 μs | 26.73 μs |  76.70 μs | 258.4 μs |  1.20 |    0.41 | 2707 |
|           LZ4SystemTextJson | 323.0 μs | 56.76 μs | 165.57 μs | 241.7 μs |  1.40 |    0.86 | 2705 |
|                 LZ4Utf8Json | 299.2 μs | 61.82 μs | 181.32 μs | 200.7 μs |  1.21 |    0.84 | 2895 |

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
|                  MsgPackCli | 471.3 μs | 115.67 μs | 339.23 μs | 293.5 μs |  1.44 |    1.00 |
|              NewtonsoftJson | 337.8 μs |  27.19 μs |  77.15 μs | 318.2 μs |  1.00 |    0.00 |
|              SystemTextJson | 289.3 μs |  45.94 μs | 133.29 μs | 226.9 μs |  0.86 |    0.35 |
|                    Utf8Json | 238.7 μs |  33.32 μs |  97.19 μs | 194.3 μs |  0.76 |    0.38 |
|     DeflateStreamMsgPackCli | 518.9 μs | 119.86 μs | 351.53 μs | 320.0 μs |  1.59 |    1.03 |
| DeflateStreamNewtonsoftJson | 382.3 μs |  35.82 μs | 103.36 μs | 340.4 μs |  1.16 |    0.29 |
| DeflateStreamSystemTextJson | 351.5 μs |  47.92 μs | 138.25 μs | 296.9 μs |  1.05 |    0.35 |
|       DeflateStreamUtf8Json | 310.9 μs |  36.83 μs | 107.42 μs | 264.1 μs |  0.97 |    0.37 |
|               LZ4MsgPackCli | 479.5 μs | 116.00 μs | 336.53 μs | 291.6 μs |  1.47 |    1.03 |
|           LZ4NewtonsoftJson | 327.6 μs |  30.88 μs |  89.10 μs | 287.4 μs |  1.00 |    0.30 |
|           LZ4SystemTextJson | 296.6 μs |  42.42 μs | 123.08 μs | 235.8 μs |  0.90 |    0.32 |
|                 LZ4Utf8Json | 250.6 μs |  32.18 μs |  93.35 μs | 213.0 μs |  0.78 |    0.30 |

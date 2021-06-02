# SpanDex

[![Build Status](https://travis-ci.org/jonorogers/SpanDex.svg?branch=master)](https://travis-ci.org/jonorogers/SpanDex)   [![nuget](https://img.shields.io/nuget/v/SpanDex.svg)](https://www.nuget.org/packages/SpanDex/) [![netstandard 2.0](https://img.shields.io/badge/netstandard-2.0-brightgreen.svg)](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)

Utilities to read/write primitives from/to spans easily. Uses the C# Span struct.

## Getting Started

Install the [Nuget Package](https://www.nuget.org/packages/SpanDex)

### Motivation

Reading/writing spans can be a chore, keeping track of where you're up to reading a span. This lib lets you simplify this:

```cs
var one = BinaryPrimitives.ReadUInt16LittleEndian(span.Slice(3, 2));
var two = BinaryPrimitives.ReadUInt32LittleEndian(span.Slice(5, 4));
var three = BinaryPrimitives.ReadUInt16BigEndian(span.Slice(9, 2));
```

to this:

```cs
int cursor = 0;
var one = span.ReadUInt16LittleEndian(ref cursor);
var two = span.ReadUInt32LittleEndian(ref cursor);
var three = span.ReadUInt16BigEndian(ref cursor);
```

or:

```cs
var spanReader = new SpanReader(span);
var one = spanReader.ReadUInt16LittleEndian();
var two = spanReader.ReadUInt32LittleEndian();
var three = spanReader.ReadUInt16BigEndian();
```

This lib is based around the `System.Buffers.Binary.BinaryPrimitives` class, with some other methods sprinkled in for some spice.

### Included types

- `SpanReader` for reading a span
- `SpanWriter` for creating and writing to a span; initialize with `size` or `Memory<byte>`
- A tonne of extension methods, applicable to `Span<byte>` and `ReadOnlySpan<byte>` - all ripped straight from `System.Buffers.Binary.BinaryPrimitives`, as well as:
- `span.ReadSpan()` - same as slice, but keeps track of where you're up to
- `span.ReadASCIIString()` - does what it says on the packet
- `span.ReadUTF8String()` - I think you get the drift

### Benchmark Results

``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.19041
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.104
  [Host]     : .NET Core 2.2.8 (CoreCLR 4.6.28207.03, CoreFX 4.6.28208.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.8 (CoreCLR 4.6.28207.03, CoreFX 4.6.28208.02), 64bit RyuJIT


```
|     Method |     N |        Mean |     Error |    StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |------ |------------:|----------:|----------:|-----:|------:|------:|------:|----------:|
| **SpanReader** |  **1000** |  **1,201.3 ns** |  **22.18 ns** |  **20.75 ns** |    **3** |     **-** |     **-** |     **-** |         **-** |
| BitConvert |  1000 |    947.9 ns |  18.67 ns |  27.37 ns |    2 |     - |     - |     - |         - |
|     Manual |  1000 |    553.7 ns |  10.96 ns |  10.77 ns |    1 |     - |     - |     - |         - |
| **SpanReader** | **10000** | **13,152.5 ns** | **262.35 ns** | **376.25 ns** |    **6** |     **-** |     **-** |     **-** |         **-** |
| BitConvert | 10000 |  9,786.4 ns | 168.66 ns | 187.47 ns |    5 |     - |     - |     - |         - |
|     Manual | 10000 |  5,379.4 ns | 107.46 ns | 182.47 ns |    4 |     - |     - |     - |         - |


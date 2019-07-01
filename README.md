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

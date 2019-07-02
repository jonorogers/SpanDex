using System;
using SpanDex.Extensions;

namespace SpanDex {
    /// <summary>
    /// Provides an easy way to read from a Span
    /// </summary>
    public ref struct SpanReader {
        private ReadOnlySpan<byte> span;
        private int cursor;

        /// <summary>
        /// Initializes a SpanReader using the given memory
        /// </summary>
        /// <param name="span">The memory to use</param>
        /// <param name="cursor">Optional initial cursor position (defaults to 0)</param>
        public SpanReader(ReadOnlySpan<byte> span, int cursor = 0) {
            this.span = span;
            this.cursor = cursor;
        }

        public static implicit operator SpanReader(byte[] array) => new SpanReader(array);
        public static implicit operator SpanReader(Span<byte> span) => new SpanReader(span);
        public static implicit operator SpanReader(ReadOnlySpan<byte> span) => new SpanReader(span);
        public static implicit operator SpanReader(ArraySegment<byte> segment) => new SpanReader(segment);

        /// <summary>
        /// The length of the memory
        /// </summary>
        public int Length => span.Length;

        public short ReadInt16BigEndian() => span.ReadInt16BigEndian(ref cursor);
        public short ReadInt16LittleEndian() => span.ReadInt16LittleEndian(ref cursor);
        public int ReadInt32BigEndian() => span.ReadInt32BigEndian(ref cursor);
        public int ReadInt32LittleEndian() => span.ReadInt32LittleEndian(ref cursor);
        public long ReadInt64BigEndian() => span.ReadInt64BigEndian(ref cursor);
        public long ReadInt64LittleEndian() => span.ReadInt64LittleEndian(ref cursor);
        [CLSCompliant(false)]
        public ushort ReadUInt16BigEndian() => span.ReadUInt16BigEndian(ref cursor);
        [CLSCompliant(false)]
        public ushort ReadUInt16LittleEndian() => span.ReadUInt16LittleEndian(ref cursor);
        [CLSCompliant(false)]
        public uint ReadUInt32BigEndian() => span.ReadUInt32BigEndian(ref cursor);
        [CLSCompliant(false)]
        public uint ReadUInt32LittleEndian() => span.ReadUInt32LittleEndian(ref cursor);
        [CLSCompliant(false)]
        public ulong ReadUInt64BigEndian() => span.ReadUInt64BigEndian(ref cursor);
        [CLSCompliant(false)]
        public ulong ReadUInt64LittleEndian() => span.ReadUInt64LittleEndian(ref cursor);
        public ReadOnlySpan<byte> ReadSpan(int size) => span.ReadSpan(size, ref cursor);
        public string ReadAsciiString(int size) => span.ReadAsciiString(size, ref cursor);
        public string ReadUtf8string(int size) => span.ReadUtf8String(size, ref cursor);
        public byte ReadByte() => span.ReadByte(ref cursor);
        public bool TryReadInt16BigEndian(out short value) => span.TryReadInt16BigEndian(out value, ref cursor);
        public bool TryReadInt16LittleEndian(out short value) => span.TryReadInt16LittleEndian(out value, ref cursor);
        public bool TryReadInt32BigEndian(out int value) => span.TryReadInt32BigEndian(out value, ref cursor);
        public bool TryReadInt32LittleEndian(out int value) => span.TryReadInt32LittleEndian(out value, ref cursor);
        public bool TryReadInt64BigEndian(out long value) => span.TryReadInt64BigEndian(out value, ref cursor);
        public bool TryReadInt64LittleEndian(out long value) => span.TryReadInt64LittleEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt16BigEndian(out ushort value) => span.TryReadUInt16BigEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt16LittleEndian(out ushort value) => span.TryReadUInt16LittleEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt32BigEndian(out uint value) => span.TryReadUInt32BigEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt32LittleEndian(out uint value) => span.TryReadUInt32LittleEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt64BigEndian(out ulong value) => span.TryReadUInt64BigEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt64LittleEndian(out ulong value) => span.TryReadUInt64LittleEndian(out value, ref cursor);
        public bool TryReadSpan(out ReadOnlySpan<byte> value, int size) => span.TryReadSpan(out value, size, ref cursor);
        public bool TryReadAsciiString(out string value, int size) => span.TryReadAsciiString(out value, size, ref cursor);
        public bool TryReadUtf8string(out string value, int size) => span.TryReadUtf8String(out value, size, ref cursor);
        public bool TryReadByte(out byte value) => span.TryReadByte(out value, ref cursor);
    }
}

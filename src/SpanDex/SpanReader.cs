using System;
using SpanDex.Extensions;

namespace SpanDex {
    public class SpanReader {
        private Memory<byte> memory;
        private int cursor = 0;

        public SpanReader(ReadOnlySpan<byte> span) {
            this.memory = span.ToArray();
        }

        public short ReadInt16BigEndian() => memory.Span.ReadInt16BigEndian(ref cursor);
        public short ReadInt16LittleEndian() => memory.Span.ReadInt16LittleEndian(ref cursor);
        public int ReadInt32BigEndian() => memory.Span.ReadInt32BigEndian(ref cursor);
        public int ReadInt32LittleEndian() => memory.Span.ReadInt32LittleEndian(ref cursor);
        public long ReadInt64BigEndian() => memory.Span.ReadInt64BigEndian(ref cursor);
        public long ReadInt64LittleEndian() => memory.Span.ReadInt64LittleEndian(ref cursor);
        [CLSCompliant(false)]
        public ushort ReadUInt16BigEndian() => memory.Span.ReadUInt16BigEndian(ref cursor);
        [CLSCompliant(false)]
        public ushort ReadUInt16LittleEndian() => memory.Span.ReadUInt16LittleEndian(ref cursor);
        [CLSCompliant(false)]
        public uint ReadUInt32BigEndian() => memory.Span.ReadUInt32BigEndian(ref cursor);
        [CLSCompliant(false)]
        public uint ReadUInt32LittleEndian() => memory.Span.ReadUInt32LittleEndian(ref cursor);
        [CLSCompliant(false)]
        public ulong ReadUInt64BigEndian() => memory.Span.ReadUInt64BigEndian(ref cursor);
        [CLSCompliant(false)]
        public ulong ReadUInt64LittleEndian() => memory.Span.ReadUInt64LittleEndian(ref cursor);
        public ReadOnlySpan<byte> ReadSpan(int size) => memory.Span.ReadSpan(size, ref cursor);
        public string ReadAsciiString(int size) => memory.Span.ReadAsciiString(size, ref cursor);
        public string ReadUtf8string(int size) => memory.Span.ReadUtf8String(size, ref cursor);
        public bool TryReadInt16BigEndian(out short value) => memory.Span.TryReadInt16BigEndian(out value, ref cursor);
        public bool TryReadInt16LittleEndian(out short value) => memory.Span.TryReadInt16LittleEndian(out value, ref cursor);
        public bool TryReadInt32BigEndian(out int value) => memory.Span.TryReadInt32BigEndian(out value, ref cursor);
        public bool TryReadInt32LittleEndian(out int value) => memory.Span.TryReadInt32LittleEndian(out value, ref cursor);
        public bool TryReadInt64BigEndian(out long value) => memory.Span.TryReadInt64BigEndian(out value, ref cursor);
        public bool TryReadInt64LittleEndian(out long value) => memory.Span.TryReadInt64LittleEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt16BigEndian(out ushort value) => memory.Span.TryReadUInt16BigEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt16LittleEndian(out ushort value) => memory.Span.TryReadUInt16LittleEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt32BigEndian(out uint value) => memory.Span.TryReadUInt32BigEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt32LittleEndian(out uint value) => memory.Span.TryReadUInt32LittleEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt64BigEndian(out ulong value) => memory.Span.TryReadUInt64BigEndian(out value, ref cursor);
        [CLSCompliant(false)]
        public bool TryReadUInt64LittleEndian(out ulong value) => memory.Span.TryReadUInt64LittleEndian(out value, ref cursor);
        public bool TryReadSpan(out ReadOnlySpan<byte> value, int size) => memory.Span.TryReadSpan(out value, size, ref cursor);
        public bool TryReadAsciiString(out string value, int size) => memory.Span.TryReadAsciiString(out value, size, ref cursor);
        public bool TryReadUtf8string(out string value, int size) => memory.Span.TryReadUtf8String(out value, size, ref cursor);
    }
}

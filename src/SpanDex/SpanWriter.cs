using System;
using SpanDex.Extensions;

namespace SpanDex {
    public class SpanWriter {
        private Memory<byte> memory;
        private int cursor = 0;
        public SpanWriter(int size) {
            if (size <= 0)
                throw new ArgumentException("Size must be a non-negative integer");

            this.memory = new byte[size];
        }
        public SpanWriter(Memory<byte> memory) {
            if (memory.Length == 0)
                throw new ArgumentNullException(nameof(memory));

            this.memory = memory;
        }
        public Span<byte> Span => memory.Span;
        public int Written => cursor;
        public int Remaining => memory.Length - cursor;

        public byte[] ToArray() => memory.ToArray();
        public ReadOnlySpan<byte> ToReadOnlySpan() => new ReadOnlySpan<byte>(ToArray());
        public void Advance(int length) {
            if (length <= 0)
                throw new ArgumentException("Length must be a non-negative integer");

            cursor = checked(cursor + length);
        }

        public bool TryWriteInt16BigEndian(short value) => memory.Span.TryWriteInt16BigEndian(value, ref cursor);
        public bool TryWriteInt16LittleEndian(short value) => memory.Span.TryWriteInt16LittleEndian(value, ref cursor);
        public bool TryWriteInt32BigEndian(int value) => memory.Span.TryWriteInt32BigEndian(value, ref cursor);
        public bool TryWriteInt32LittleEndian(int value) => memory.Span.TryWriteInt32LittleEndian(value, ref cursor);
        public bool TryWriteInt64BigEndian(long value) => memory.Span.TryWriteInt64BigEndian(value, ref cursor);
        public bool TryWriteInt64LittleEndian(long value) => memory.Span.TryWriteInt64LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt16BigEndian(ushort value) => memory.Span.TryWriteUInt16BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt16LittleEndian(ushort value) => memory.Span.TryWriteUInt16LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt32BigEndian(uint value) => memory.Span.TryWriteUInt32BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt32LittleEndian(uint value) => memory.Span.TryWriteUInt32LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt64BigEndian(ulong value) => memory.Span.TryWriteUInt64BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt64LittleEndian(ulong value) => memory.Span.TryWriteUInt64LittleEndian(value, ref cursor);
        public bool TryWriteSpan(ReadOnlySpan<byte> value) => memory.Span.TryWriteSpan(value, ref cursor);
        public bool TryWriteAsciiString(string value) => memory.Span.TryWriteAsciiString(value, ref cursor);
        public bool TryWriteUtf8String(string value) => memory.Span.TryWriteUtf8String(value, ref cursor);
        public void WriteInt16BigEndian(short value) => memory.Span.WriteInt16BigEndian(value, ref cursor);
        public void WriteInt16LittleEndian(short value) => memory.Span.WriteInt16LittleEndian(value, ref cursor);
        public void WriteInt32BigEndian(int value) => memory.Span.WriteInt32BigEndian(value, ref cursor);
        public void WriteInt32LittleEndian(int value) => memory.Span.WriteInt32LittleEndian(value, ref cursor);
        public void WriteInt64BigEndian(long value) => memory.Span.WriteInt64BigEndian(value, ref cursor);
        public void WriteInt64LittleEndian(long value) => memory.Span.WriteInt64LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt16BigEndian(ushort value) => memory.Span.WriteUInt16BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt16LittleEndian(ushort value) => memory.Span.WriteUInt16LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt32BigEndian(uint value) => memory.Span.WriteUInt32BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt32LittleEndian(uint value) => memory.Span.WriteUInt32LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt64BigEndian(ulong value) => memory.Span.WriteUInt64BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt64LittleEndian(ulong value) => memory.Span.WriteUInt64LittleEndian(value, ref cursor);
        public void WriteSpan(ReadOnlySpan<byte> value) => memory.Span.WriteSpan(value, ref cursor);
        public void WriteAsciiString(string value) => memory.Span.WriteAsciiString(value, ref cursor);
        public void WriteUtf8String(string value) => memory.Span.WriteUtf8String(value, ref cursor);

    }
}

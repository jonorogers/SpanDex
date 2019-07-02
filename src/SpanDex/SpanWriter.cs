using System;
using SpanDex.Extensions;

namespace SpanDex {
    public ref struct SpanWriter {
        public readonly Span<byte> Span;
        private int cursor;
        public SpanWriter(int size) {
            if (size <= 0)
                throw new ArgumentException("Size must be a non-negative integer");

            this.Span = new byte[size];
            this.cursor = 0;
        }
        public SpanWriter(Span<byte> span) {
            if (span.Length == 0)
                throw new ArgumentNullException(nameof(span));

            this.Span = span;
            this.cursor = 0;
        }

        public static implicit operator SpanWriter(byte[] array) => new SpanWriter(array);
        public static implicit operator SpanWriter(Span<byte> span) => new SpanWriter(span);
        public static implicit operator SpanWriter(ArraySegment<byte> segment) => new SpanWriter(segment);

        public int Written => cursor;
        public int Remaining => Span.Length - cursor;
        public int Length => Span.Length;

        public byte[] ToArray() => Span.ToArray();
        public ReadOnlySpan<byte> ToReadOnlySpan() => new ReadOnlySpan<byte>(ToArray());
        public void Advance(int length) {
            if (length <= 0)
                throw new ArgumentException("Length must be a non-negative integer");

            cursor = checked(cursor + length);
        }

        public bool TryWriteInt16BigEndian(short value) => Span.TryWriteInt16BigEndian(value, ref cursor);
        public bool TryWriteInt16LittleEndian(short value) => Span.TryWriteInt16LittleEndian(value, ref cursor);
        public bool TryWriteInt32BigEndian(int value) => Span.TryWriteInt32BigEndian(value, ref cursor);
        public bool TryWriteInt32LittleEndian(int value) => Span.TryWriteInt32LittleEndian(value, ref cursor);
        public bool TryWriteInt64BigEndian(long value) => Span.TryWriteInt64BigEndian(value, ref cursor);
        public bool TryWriteInt64LittleEndian(long value) => Span.TryWriteInt64LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt16BigEndian(ushort value) => Span.TryWriteUInt16BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt16LittleEndian(ushort value) => Span.TryWriteUInt16LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt32BigEndian(uint value) => Span.TryWriteUInt32BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt32LittleEndian(uint value) => Span.TryWriteUInt32LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt64BigEndian(ulong value) => Span.TryWriteUInt64BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public bool TryWriteUInt64LittleEndian(ulong value) => Span.TryWriteUInt64LittleEndian(value, ref cursor);
        public bool TryWriteSpan(ReadOnlySpan<byte> value) => Span.TryWriteSpan(value, ref cursor);
        public bool TryWriteAsciiString(string value) => Span.TryWriteAsciiString(value, ref cursor);
        public bool TryWriteUtf8String(string value) => Span.TryWriteUtf8String(value, ref cursor);
        public void WriteInt16BigEndian(short value) => Span.WriteInt16BigEndian(value, ref cursor);
        public void WriteInt16LittleEndian(short value) => Span.WriteInt16LittleEndian(value, ref cursor);
        public void WriteInt32BigEndian(int value) => Span.WriteInt32BigEndian(value, ref cursor);
        public void WriteInt32LittleEndian(int value) => Span.WriteInt32LittleEndian(value, ref cursor);
        public void WriteInt64BigEndian(long value) => Span.WriteInt64BigEndian(value, ref cursor);
        public void WriteInt64LittleEndian(long value) => Span.WriteInt64LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt16BigEndian(ushort value) => Span.WriteUInt16BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt16LittleEndian(ushort value) => Span.WriteUInt16LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt32BigEndian(uint value) => Span.WriteUInt32BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt32LittleEndian(uint value) => Span.WriteUInt32LittleEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt64BigEndian(ulong value) => Span.WriteUInt64BigEndian(value, ref cursor);
        [CLSCompliant(false)]
        public void WriteUInt64LittleEndian(ulong value) => Span.WriteUInt64LittleEndian(value, ref cursor);
        public void WriteSpan(ReadOnlySpan<byte> value) => Span.WriteSpan(value, ref cursor);
        public void WriteAsciiString(string value) => Span.WriteAsciiString(value, ref cursor);
        public void WriteUtf8String(string value) => Span.WriteUtf8String(value, ref cursor);

    }
}

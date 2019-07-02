using System;
using System.Buffers.Binary;
using System.Text;

namespace SpanDex {
    internal static class SpanWriting {


        internal static bool TryWriteInt16BigEndian(Span<byte> destination, short value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteInt16BigEndian(destination.Slice(cursor, 2), value), ref cursor, 2);
        }
        internal static bool TryWriteInt16LittleEndian(Span<byte> destination, short value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteInt16LittleEndian(destination.Slice(cursor, 2), value), ref cursor, 2);
        }
        internal static bool TryWriteInt32BigEndian(Span<byte> destination, int value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteInt32BigEndian(destination.Slice(cursor, 4), value), ref cursor, 4);
        }
        internal static bool TryWriteInt32LittleEndian(Span<byte> destination, int value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteInt32LittleEndian(destination.Slice(cursor, 4), value), ref cursor, 4);
        }
        internal static bool TryWriteInt64BigEndian(Span<byte> destination, long value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteInt64BigEndian(destination.Slice(cursor, 8), value), ref cursor, 8);
        }
        internal static bool TryWriteInt64LittleEndian(Span<byte> destination, long value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteInt64LittleEndian(destination.Slice(cursor, 8), value), ref cursor, 8);
        }
        internal static bool TryWriteUInt16BigEndian(Span<byte> destination, ushort value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteUInt16BigEndian(destination.Slice(cursor, 2), value), ref cursor, 2);
        }
        internal static bool TryWriteUInt16LittleEndian(Span<byte> destination, ushort value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteUInt16LittleEndian(destination.Slice(cursor, 2), value), ref cursor, 2);
        }
        internal static bool TryWriteUInt32BigEndian(Span<byte> destination, uint value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteUInt32BigEndian(destination.Slice(cursor, 4), value), ref cursor, 4);
        }
        internal static bool TryWriteUInt32LittleEndian(Span<byte> destination, uint value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteUInt32LittleEndian(destination.Slice(cursor, 4), value), ref cursor, 4);
        }
        internal static bool TryWriteUInt64BigEndian(Span<byte> destination, ulong value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteUInt64BigEndian(destination.Slice(cursor, 8), value), ref cursor, 8);
        }
        internal static bool TryWriteUInt64LittleEndian(Span<byte> destination, ulong value, ref int cursor) {
            return TryAdvance(BinaryPrimitives.TryWriteUInt64LittleEndian(destination.Slice(cursor, 8), value), ref cursor, 8);
        }
        internal static bool TryWriteSpan(Span<byte> destination, ReadOnlySpan<byte> value, ref int cursor) {
            if (destination.HasSpace(value.Length + cursor)) {
                WriteSpan(destination, value, ref cursor);
                return true;
            }
            return false;
        }
        internal static bool TryWriteAsciiString(Span<byte> destination, string value, ref int cursor) {
            return TryWriteSpan(destination, Encoding.ASCII.GetBytes(value), ref cursor);
        }
        internal static bool TryWriteUtf8String(Span<byte> destination, string value, ref int cursor) {
            return TryWriteSpan(destination, Encoding.UTF8.GetBytes(value), ref cursor);
        }
        internal static void WriteInt16BigEndian(Span<byte> destination, short value, ref int cursor) {
            BinaryPrimitives.WriteInt16BigEndian(destination.SliceAndAdvance(ref cursor, 2), value);
        }
        internal static void WriteInt16LittleEndian(Span<byte> destination, short value, ref int cursor) {
            BinaryPrimitives.WriteInt16LittleEndian(destination.SliceAndAdvance(ref cursor, 2), value);
        }
        internal static void WriteInt32BigEndian(Span<byte> destination, int value, ref int cursor) {
            BinaryPrimitives.WriteInt32BigEndian(destination.SliceAndAdvance(ref cursor, 4), value);
        }
        internal static void WriteInt32LittleEndian(Span<byte> destination, int value, ref int cursor) {
            BinaryPrimitives.WriteInt32LittleEndian(destination.SliceAndAdvance(ref cursor, 4), value);
        }
        internal static void WriteInt64BigEndian(Span<byte> destination, long value, ref int cursor) {
            BinaryPrimitives.WriteInt64BigEndian(destination.SliceAndAdvance(ref cursor, 8), value);
        }
        internal static void WriteInt64LittleEndian(Span<byte> destination, long value, ref int cursor) {
            BinaryPrimitives.WriteInt64LittleEndian(destination.SliceAndAdvance(ref cursor, 8), value);
        }
        internal static void WriteUInt16BigEndian(Span<byte> destination, ushort value, ref int cursor) {
            BinaryPrimitives.WriteUInt16BigEndian(destination.SliceAndAdvance(ref cursor, 2), value);
        }
        internal static void WriteUInt16LittleEndian(Span<byte> destination, ushort value, ref int cursor) {
            BinaryPrimitives.WriteUInt16LittleEndian(destination.SliceAndAdvance(ref cursor, 2), value);
        }
        internal static void WriteUInt32BigEndian(Span<byte> destination, uint value, ref int cursor) {
            BinaryPrimitives.WriteUInt32BigEndian(destination.SliceAndAdvance(ref cursor, 4), value);
        }
        internal static void WriteUInt32LittleEndian(Span<byte> destination, uint value, ref int cursor) {
            BinaryPrimitives.WriteUInt32LittleEndian(destination.SliceAndAdvance(ref cursor, 4), value);
        }
        internal static void WriteUInt64BigEndian(Span<byte> destination, ulong value, ref int cursor) {
            BinaryPrimitives.WriteUInt64BigEndian(destination.SliceAndAdvance(ref cursor, 8), value);
        }
        internal static void WriteUInt64LittleEndian(Span<byte> destination, ulong value, ref int cursor) {
            BinaryPrimitives.WriteUInt64LittleEndian(destination.SliceAndAdvance(ref cursor, 8), value);
        }
        internal static void WriteSpan(Span<byte> destination, ReadOnlySpan<byte> value, ref int cursor) {
            value.CopyTo(destination.Slice(cursor, value.Length));
            cursor += value.Length;
        }
        internal static void WriteAsciiString(Span<byte> destination, string value, ref int cursor) {
            WriteSpan(destination, Encoding.ASCII.GetBytes(value), ref cursor);
        }
        internal static void WriteUtf8String(Span<byte> destination, string value, ref int cursor) {
            WriteSpan(destination, Encoding.UTF8.GetBytes(value), ref cursor);
        }

        private static Span<byte> SliceAndAdvance(this Span<byte> source, ref int cursor, int size) {
            Span<byte> slice = source.Slice(cursor, size);
            cursor += size;
            return slice;
        }
        private static bool TryAdvance(bool succeeded, ref int cursor, int size) {
            if (succeeded)
                cursor += size;
            return succeeded;
        }
        private static bool HasSpace(this Span<byte> source, int space) => source.Length >= space;
    }
}

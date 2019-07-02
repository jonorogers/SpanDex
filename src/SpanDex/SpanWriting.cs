using System;
using System.Buffers.Binary;
using System.Text;

namespace SpanDex {
    internal static class SpanWriting {


        internal static bool TryWriteInt16BigEndian(Span<byte> destination, short value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 2))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteInt16BigEndian(destination.Slice(cursor, 2), value), ref cursor, 2);
        }

        internal static bool TryWriteInt16LittleEndian(Span<byte> destination, short value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 2))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteInt16LittleEndian(destination.Slice(cursor, 2), value), ref cursor, 2);
        }

        internal static bool TryWriteInt32BigEndian(Span<byte> destination, int value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 4))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteInt32BigEndian(destination.Slice(cursor, 4), value), ref cursor, 4);
        }

        internal static bool TryWriteInt32LittleEndian(Span<byte> destination, int value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 4))
                return false;


            return TryAdvance(BinaryPrimitives.TryWriteInt32LittleEndian(destination.Slice(cursor, 4), value), ref cursor, 4);
        }

        internal static bool TryWriteInt64BigEndian(Span<byte> destination, long value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 8))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteInt64BigEndian(destination.Slice(cursor, 8), value), ref cursor, 8);
        }

        internal static bool TryWriteInt64LittleEndian(Span<byte> destination, long value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 8))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteInt64LittleEndian(destination.Slice(cursor, 8), value), ref cursor, 8);
        }

        internal static bool TryWriteUInt16BigEndian(Span<byte> destination, ushort value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 2))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteUInt16BigEndian(destination.Slice(cursor, 2), value), ref cursor, 2);
        }

        internal static bool TryWriteUInt16LittleEndian(Span<byte> destination, ushort value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 2))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteUInt16LittleEndian(destination.Slice(cursor, 2), value), ref cursor, 2);
        }

        internal static bool TryWriteUInt32BigEndian(Span<byte> destination, uint value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 4))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteUInt32BigEndian(destination.Slice(cursor, 4), value), ref cursor, 4);
        }

        internal static bool TryWriteUInt32LittleEndian(Span<byte> destination, uint value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 4))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteUInt32LittleEndian(destination.Slice(cursor, 4), value), ref cursor, 4);
        }

        internal static bool TryWriteUInt64BigEndian(Span<byte> destination, ulong value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 8))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteUInt64BigEndian(destination.Slice(cursor, 8), value), ref cursor, 8);
        }

        internal static bool TryWriteUInt64LittleEndian(Span<byte> destination, ulong value, ref int cursor) {
            if (!ValidateTryWrite(destination, cursor, 8))
                return false;

            return TryAdvance(BinaryPrimitives.TryWriteUInt64LittleEndian(destination.Slice(cursor, 8), value), ref cursor, 8);
        }

        internal static bool TryWriteSpan(Span<byte> destination, ReadOnlySpan<byte> value, ref int cursor) {
            ValidateCursor(cursor);
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (destination.HasSpace(cursor + value.Length)) {
                WriteSpan(destination, value, ref cursor);
                return true;
            }
            return false;
        }

        internal static bool TryWriteAsciiString(Span<byte> destination, string value, ref int cursor) {
            ValidateCursor(cursor);
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return TryWriteSpan(destination, Encoding.ASCII.GetBytes(value), ref cursor);
        }

        internal static bool TryWriteUtf8String(Span<byte> destination, string value, ref int cursor) {
            ValidateCursor(cursor);
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return TryWriteSpan(destination, Encoding.UTF8.GetBytes(value), ref cursor);
        }

        internal static bool TryWriteByte(Span<byte> destination, byte value, ref int cursor) {
            if(destination.HasSpace(cursor + 1)) {
                WriteByte(destination, value, ref cursor);
                return true;
            }
            return false;
        }

        internal static void WriteInt16BigEndian(Span<byte> destination, short value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteInt16BigEndian(destination.SliceAndAdvance(ref cursor, 2), value);
        }

        internal static void WriteInt16LittleEndian(Span<byte> destination, short value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteInt16LittleEndian(destination.SliceAndAdvance(ref cursor, 2), value);
        }

        internal static void WriteInt32BigEndian(Span<byte> destination, int value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteInt32BigEndian(destination.SliceAndAdvance(ref cursor, 4), value);
        }

        internal static void WriteInt32LittleEndian(Span<byte> destination, int value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteInt32LittleEndian(destination.SliceAndAdvance(ref cursor, 4), value);
        }

        internal static void WriteInt64BigEndian(Span<byte> destination, long value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteInt64BigEndian(destination.SliceAndAdvance(ref cursor, 8), value);
        }

        internal static void WriteInt64LittleEndian(Span<byte> destination, long value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteInt64LittleEndian(destination.SliceAndAdvance(ref cursor, 8), value);
        }

        internal static void WriteUInt16BigEndian(Span<byte> destination, ushort value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteUInt16BigEndian(destination.SliceAndAdvance(ref cursor, 2), value);
        }

        internal static void WriteUInt16LittleEndian(Span<byte> destination, ushort value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteUInt16LittleEndian(destination.SliceAndAdvance(ref cursor, 2), value);
        }

        internal static void WriteUInt32BigEndian(Span<byte> destination, uint value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteUInt32BigEndian(destination.SliceAndAdvance(ref cursor, 4), value);
        }

        internal static void WriteUInt32LittleEndian(Span<byte> destination, uint value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteUInt32LittleEndian(destination.SliceAndAdvance(ref cursor, 4), value);
        }

        internal static void WriteUInt64BigEndian(Span<byte> destination, ulong value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteUInt64BigEndian(destination.SliceAndAdvance(ref cursor, 8), value);
        }

        internal static void WriteUInt64LittleEndian(Span<byte> destination, ulong value, ref int cursor) {
            ValidateCursor(cursor);
            BinaryPrimitives.WriteUInt64LittleEndian(destination.SliceAndAdvance(ref cursor, 8), value);
        }

        internal static void WriteSpan(Span<byte> destination, ReadOnlySpan<byte> value, ref int cursor) {
            ValidateCursor(cursor);
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            value.CopyTo(destination.Slice(cursor, value.Length));
            IncrementCursor(ref cursor, value.Length);
        }

        internal static void WriteAsciiString(Span<byte> destination, string value, ref int cursor) {
            ValidateCursor(cursor);
            if (value == null) 
                throw new ArgumentNullException(nameof(value));

            WriteSpan(destination, Encoding.ASCII.GetBytes(value), ref cursor);
        }

        internal static void WriteUtf8String(Span<byte> destination, string value, ref int cursor) {
            ValidateCursor(cursor);
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            WriteSpan(destination, Encoding.UTF8.GetBytes(value), ref cursor);
        }

        internal static void WriteByte(Span<byte> destination, byte value, ref int cursor) {
            ValidateCursor(cursor);
            destination[cursor] = value;
            IncrementCursor(ref cursor, 1);
        }

        private static bool ValidateTryWrite(Span<byte> source, int cursor, int size) {
            ValidateCursor(cursor);
            return HasSpace(source, cursor + size);
        }

        private static Span<byte> SliceAndAdvance(this Span<byte> source, ref int cursor, int size) {
            Span<byte> slice = source.Slice(cursor, size);
            IncrementCursor(ref cursor, size);
            return slice;
        }

        private static bool TryAdvance(bool succeeded, ref int cursor, int size) {
            if (succeeded)
                IncrementCursor(ref cursor, size);
            return succeeded;
        }

        private static void IncrementCursor(ref int cursor, int size) => cursor = checked(cursor + size);

        private static bool HasSpace(this Span<byte> source, int space) => source.Length >= space;

        private static void ValidateCursor(int cursor) {
            if (cursor < 0)
                throw new ArgumentException("Cursor cannot be less than 0");
        }
    }
}

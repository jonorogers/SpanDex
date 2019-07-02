using System;

namespace SpanDex.Extensions {
    public static class SpanExtensions {

        public static short ReadInt16BigEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadInt16BigEndian(source, ref cursor);
        public static short ReadInt16LittleEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadInt16LittleEndian(source, ref cursor);
        public static int ReadInt32BigEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadInt32BigEndian(source, ref cursor);
        public static int ReadInt32LittleEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadInt32LittleEndian(source, ref cursor);
        public static long ReadInt64BigEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadInt64BigEndian(source, ref cursor);
        public static long ReadInt64LittleEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadInt64LittleEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static ushort ReadUInt16BigEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadUInt16BigEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static ushort ReadUInt16LittleEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadUInt16LittleEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static uint ReadUInt32BigEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadUInt32BigEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static uint ReadUInt32LittleEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadUInt32LittleEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static ulong ReadUInt64BigEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadUInt64BigEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static ulong ReadUInt64LittleEndian(this ReadOnlySpan<byte> source, ref int cursor) => SpanReading.ReadUInt64LittleEndian(source, ref cursor);
        public static ReadOnlySpan<byte> ReadSpan(this ReadOnlySpan<byte> source, int size, ref int cursor) => SpanReading.ReadSpan(source, size, ref cursor);
        public static string ReadAsciiString(this ReadOnlySpan<byte> source, int size, ref int cursor) => SpanReading.ReadAsciiString(source, size, ref cursor);
        public static string ReadUtf8String(this ReadOnlySpan<byte> source, int size, ref int cursor) => SpanReading.ReadUtf8String(source, size, ref cursor);
        public static bool TryReadInt16BigEndian(this ReadOnlySpan<byte> source, out short value, ref int cursor) => SpanReading.TryReadInt16BigEndian(source, out value, ref cursor);
        public static bool TryReadInt16LittleEndian(this ReadOnlySpan<byte> source, out short value, ref int cursor) => SpanReading.TryReadInt16LittleEndian(source, out value, ref cursor);
        public static bool TryReadInt32BigEndian(this ReadOnlySpan<byte> source, out int value, ref int cursor) => SpanReading.TryReadInt32BigEndian(source, out value, ref cursor);
        public static bool TryReadInt32LittleEndian(this ReadOnlySpan<byte> source, out int value, ref int cursor) => SpanReading.TryReadInt32LittleEndian(source, out value, ref cursor);
        public static bool TryReadInt64BigEndian(this ReadOnlySpan<byte> source, out long value, ref int cursor) => SpanReading.TryReadInt64BigEndian(source, out value, ref cursor);
        public static bool TryReadInt64LittleEndian(this ReadOnlySpan<byte> source, out long value, ref int cursor) => SpanReading.TryReadInt64LittleEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt16BigEndian(this ReadOnlySpan<byte> source, out ushort value, ref int cursor) => SpanReading.TryReadUInt16BigEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt16LittleEndian(this ReadOnlySpan<byte> source, out ushort value, ref int cursor) => SpanReading.TryReadUInt16LittleEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt32BigEndian(this ReadOnlySpan<byte> source, out uint value, ref int cursor) => SpanReading.TryReadUInt32BigEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt32LittleEndian(this ReadOnlySpan<byte> source, out uint value, ref int cursor) => SpanReading.TryReadUInt32LittleEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt64BigEndian(this ReadOnlySpan<byte> source, out ulong value, ref int cursor) => SpanReading.TryReadUInt64BigEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt64LittleEndian(this ReadOnlySpan<byte> source, out ulong value, ref int cursor) => SpanReading.TryReadUInt64LittleEndian(source, out value, ref cursor);
        public static bool TryReadSpan(this ReadOnlySpan<byte> source, out ReadOnlySpan<byte> value, int size, ref int cursor) => SpanReading.TryReadSpan(source, out value, size, ref cursor);
        public static bool TryReadAsciiString(this ReadOnlySpan<byte> source, out string value, int size, ref int cursor) => SpanReading.TryReadAsciiString(source, out value, size, ref cursor);
        public static bool TryReadUtf8String(this ReadOnlySpan<byte> source, out string value, int size, ref int cursor) => SpanReading.TryReadUtf8String(source, out value, size, ref cursor);
        public static short ReadInt16BigEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadInt16BigEndian(source, ref cursor);
        public static short ReadInt16LittleEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadInt16LittleEndian(source, ref cursor);
        public static int ReadInt32BigEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadInt32BigEndian(source, ref cursor);
        public static int ReadInt32LittleEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadInt32LittleEndian(source, ref cursor);
        public static long ReadInt64BigEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadInt64BigEndian(source, ref cursor);
        public static long ReadInt64LittleEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadInt64LittleEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static ushort ReadUInt16BigEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadUInt16BigEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static ushort ReadUInt16LittleEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadUInt16LittleEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static uint ReadUInt32BigEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadUInt32BigEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static uint ReadUInt32LittleEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadUInt32LittleEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static ulong ReadUInt64BigEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadUInt64BigEndian(source, ref cursor);
        [CLSCompliant(false)]
        public static ulong ReadUInt64LittleEndian(this Span<byte> source, ref int cursor) => SpanReading.ReadUInt64LittleEndian(source, ref cursor);
        public static ReadOnlySpan<byte> ReadSpan(this Span<byte> source, int size, ref int cursor) => SpanReading.ReadSpan(source, size, ref cursor);
        public static string ReadAsciiString(this Span<byte> source, int size, ref int cursor) => SpanReading.ReadAsciiString(source, size, ref cursor);
        public static string ReadUtf8String(this Span<byte> source, int size, ref int cursor) => SpanReading.ReadUtf8String(source, size, ref cursor);
        public static bool TryReadInt16BigEndian(this Span<byte> source, out short value, ref int cursor) => SpanReading.TryReadInt16BigEndian(source, out value, ref cursor);
        public static bool TryReadInt16LittleEndian(this Span<byte> source, out short value, ref int cursor) => SpanReading.TryReadInt16LittleEndian(source, out value, ref cursor);
        public static bool TryReadInt32BigEndian(this Span<byte> source, out int value, ref int cursor) => SpanReading.TryReadInt32BigEndian(source, out value, ref cursor);
        public static bool TryReadInt32LittleEndian(this Span<byte> source, out int value, ref int cursor) => SpanReading.TryReadInt32LittleEndian(source, out value, ref cursor);
        public static bool TryReadInt64BigEndian(this Span<byte> source, out long value, ref int cursor) => SpanReading.TryReadInt64BigEndian(source, out value, ref cursor);
        public static bool TryReadInt64LittleEndian(this Span<byte> source, out long value, ref int cursor) => SpanReading.TryReadInt64LittleEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt16BigEndian(this Span<byte> source, out ushort value, ref int cursor) => SpanReading.TryReadUInt16BigEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt16LittleEndian(this Span<byte> source, out ushort value, ref int cursor) => SpanReading.TryReadUInt16LittleEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt32BigEndian(this Span<byte> source, out uint value, ref int cursor) => SpanReading.TryReadUInt32BigEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt32LittleEndian(this Span<byte> source, out uint value, ref int cursor) => SpanReading.TryReadUInt32LittleEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt64BigEndian(this Span<byte> source, out ulong value, ref int cursor) => SpanReading.TryReadUInt64BigEndian(source, out value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryReadUInt64LittleEndian(this Span<byte> source, out ulong value, ref int cursor) => SpanReading.TryReadUInt64LittleEndian(source, out value, ref cursor);
        public static bool TryReadSpan(this Span<byte> source, out ReadOnlySpan<byte> value, int size, ref int cursor) => SpanReading.TryReadSpan(source, out value, size, ref cursor);
        public static bool TryReadAsciiString(this Span<byte> source, out string value, int size, ref int cursor) => SpanReading.TryReadAsciiString(source, out value, size, ref cursor);
        public static bool TryReadUtf8String(this Span<byte> source, out string value, int size, ref int cursor) => SpanReading.TryReadUtf8String(source, out value, size, ref cursor);




        public static bool TryWriteInt16BigEndian(this Span<byte> destination, short value, ref int cursor) => SpanWriting.TryWriteInt16BigEndian(destination, value, ref cursor);
        public static bool TryWriteInt16LittleEndian(this Span<byte> destination, short value, ref int cursor) => SpanWriting.TryWriteInt16LittleEndian(destination, value, ref cursor);
        public static bool TryWriteInt32BigEndian(this Span<byte> destination, int value, ref int cursor) => SpanWriting.TryWriteInt32BigEndian(destination, value, ref cursor);
        public static bool TryWriteInt32LittleEndian(this Span<byte> destination, int value, ref int cursor) => SpanWriting.TryWriteInt32LittleEndian(destination, value, ref cursor);
        public static bool TryWriteInt64BigEndian(this Span<byte> destination, long value, ref int cursor) => SpanWriting.TryWriteInt64BigEndian(destination, value, ref cursor);
        public static bool TryWriteInt64LittleEndian(this Span<byte> destination, long value, ref int cursor) => SpanWriting.TryWriteInt64LittleEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryWriteUInt16BigEndian(this Span<byte> destination, ushort value, ref int cursor) => SpanWriting.TryWriteUInt16BigEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryWriteUInt16LittleEndian(this Span<byte> destination, ushort value, ref int cursor) => SpanWriting.TryWriteUInt16LittleEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryWriteUInt32BigEndian(this Span<byte> destination, uint value, ref int cursor) => SpanWriting.TryWriteUInt32BigEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryWriteUInt32LittleEndian(this Span<byte> destination, uint value, ref int cursor) => SpanWriting.TryWriteUInt32LittleEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryWriteUInt64BigEndian(this Span<byte> destination, ulong value, ref int cursor) => SpanWriting.TryWriteUInt64BigEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static bool TryWriteUInt64LittleEndian(this Span<byte> destination, ulong value, ref int cursor) => SpanWriting.TryWriteUInt64LittleEndian(destination, value, ref cursor);
        public static bool TryWriteSpan(this Span<byte> destination, ReadOnlySpan<byte> value, ref int cursor) => SpanWriting.TryWriteSpan(destination, value, ref cursor);
        public static bool TryWriteAsciiString(this Span<byte> destination, string value, ref int cursor) => SpanWriting.TryWriteAsciiString(destination, value, ref cursor);
        public static bool TryWriteUtf8String(this Span<byte> destination, string value, ref int cursor) => SpanWriting.TryWriteUtf8String(destination, value, ref cursor);
        public static void WriteInt16BigEndian(this Span<byte> destination, short value, ref int cursor) => SpanWriting.WriteInt16BigEndian(destination, value, ref cursor);
        public static void WriteInt16LittleEndian(this Span<byte> destination, short value, ref int cursor) => SpanWriting.WriteInt16LittleEndian(destination, value, ref cursor);
        public static void WriteInt32BigEndian(this Span<byte> destination, int value, ref int cursor) => SpanWriting.WriteInt32BigEndian(destination, value, ref cursor);
        public static void WriteInt32LittleEndian(this Span<byte> destination, int value, ref int cursor) => SpanWriting.WriteInt32LittleEndian(destination, value, ref cursor);
        public static void WriteInt64BigEndian(this Span<byte> destination, long value, ref int cursor) => SpanWriting.WriteInt64BigEndian(destination, value, ref cursor);
        public static void WriteInt64LittleEndian(this Span<byte> destination, long value, ref int cursor) => SpanWriting.WriteInt64LittleEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static void WriteUInt16BigEndian(this Span<byte> destination, ushort value, ref int cursor) => SpanWriting.WriteUInt16BigEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static void WriteUInt16LittleEndian(this Span<byte> destination, ushort value, ref int cursor) => SpanWriting.WriteUInt16LittleEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static void WriteUInt32BigEndian(this Span<byte> destination, uint value, ref int cursor) => SpanWriting.WriteUInt32BigEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static void WriteUInt32LittleEndian(this Span<byte> destination, uint value, ref int cursor) => SpanWriting.WriteUInt32LittleEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static void WriteUInt64BigEndian(this Span<byte> destination, ulong value, ref int cursor) => SpanWriting.WriteUInt64BigEndian(destination, value, ref cursor);
        [CLSCompliant(false)]
        public static void WriteUInt64LittleEndian(this Span<byte> destination, ulong value, ref int cursor) => SpanWriting.WriteUInt64LittleEndian(destination, value, ref cursor);
        public static void WriteSpan(this Span<byte> destination, ReadOnlySpan<byte> value, ref int cursor) => SpanWriting.WriteSpan(destination, value, ref cursor);
        public static void WriteAsciiString(this Span<byte> destination, string value, ref int cursor) => SpanWriting.WriteAsciiString(destination, value, ref cursor);
        public static void WriteUtf8String(this Span<byte> destination, string value, ref int cursor) => SpanWriting.WriteUtf8String(destination, value, ref cursor);
    }
}

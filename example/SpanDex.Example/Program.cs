using System;
using SpanDex.Extensions;

namespace SpanDex.Example {
    internal static class Program {
        private static void Main() {
            // Create a buffer
            var bytes = new byte[] { 0xA0, 0x1A, 0x35, 0x91, 0xE9, 0x51, 0x0C, 0x79, 0x04, 0xD1, 0x57, 0x81, 0x1D, 0x27 };
            var span = new ReadOnlySpan<byte>(bytes);
            // Read from it
            int cursor = 0;
            ushort one = span.ReadUInt16BigEndian(ref cursor);
            uint two = span.ReadUInt32BigEndian(ref cursor);
            ulong three = span.ReadUInt64BigEndian(ref cursor);

            Console.WriteLine($"One: {one}");
            Console.WriteLine($"Two: {two}");
            Console.WriteLine($"Three: {three}");

            const string testString = "this is a test string!";

            var writer = new SpanWriter(36);
            writer.WriteInt16BigEndian(-31_971);
            writer.WriteInt32BigEndian(-1_598_468_598);
            writer.WriteInt64BigEndian(-7_223_372_036_854_775_808);
            writer.WriteAsciiString(testString);

            var reader = new SpanReader(writer.Span);
            Console.WriteLine(reader.ReadInt16BigEndian());
            Console.WriteLine(reader.ReadInt32BigEndian());
            Console.WriteLine(reader.ReadInt64BigEndian());
            Console.WriteLine(reader.ReadAsciiString(testString.Length));

            Console.ReadKey();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SpanDex.Extensions;
using System.Linq;
using System.Text;

namespace SpanDex.Tests {
    internal enum Endianness {
        Little,
        Big
    }
    [TestClass]
    public class SpanExtensionTests {
        private int cursor = 0;

        [TestMethod]
        public void ReadInt16BigEndian_ReadsCorrectly() {
            var span = GetSpan((short)-31_971, Endianness.Big);
            var value = span.ReadInt16BigEndian(ref cursor);
            Assert.AreEqual(-31_971, value);
        }
        [TestMethod]
        public void ReadInt16LittleEndian_ReadsCorrectly() {
            var span = GetSpan(-31_971, Endianness.Little);
            var value = span.ReadInt16LittleEndian(ref cursor);
            Assert.AreEqual(-31_971, value);
        }
        [TestMethod]
        public void ReadInt32BigEndian_ReadsCorrectly() {
            var span = GetSpan(-1_598_468_598, Endianness.Big);
            var value = span.ReadInt32BigEndian(ref cursor);
            Assert.AreEqual(-1_598_468_598, value);
        }
        [TestMethod]
        public void ReadInt32LittleEndian_ReadsCorrectly() {
            var span = GetSpan(-1_598_468_598, Endianness.Little);
            var value = span.ReadInt32LittleEndian(ref cursor);
            Assert.AreEqual(-1_598_468_598, value);
        }
        [TestMethod]
        public void ReadInt64BigEndian_ReadsCorrectly() {
            var span = GetSpan(-7_223_372_036_854_775_808, Endianness.Big);
            var value = span.ReadInt64BigEndian(ref cursor);
            Assert.AreEqual(-7_223_372_036_854_775_808, value);
        }
        [TestMethod]
        public void ReadInt64LittleEndian_ReadsCorrectly() {
            var span = GetSpan(-7_223_372_036_854_775_808, Endianness.Little);
            var value = span.ReadInt64LittleEndian(ref cursor);
            Assert.AreEqual(-7_223_372_036_854_775_808, value);
        }
        [TestMethod]
        public void ReadUInt16BigEndian_ReadsCorrectly() {
            var span = GetSpan((ushort)26_598, Endianness.Big);
            var value = span.ReadUInt16BigEndian(ref cursor);
            Assert.AreEqual(26_598, value);
        }
        [TestMethod]
        public void ReadUInt16LittleEndian_ReadsCorrectly() {
            var span = GetSpan(26_598, Endianness.Little);
            var value = span.ReadUInt16LittleEndian(ref cursor);
            Assert.AreEqual(26_598, value);
        }
        [TestMethod]
        public void ReadUInt32BigEndian_ReadsCorrectly() {
            var span = GetSpan(4_293_568_955, Endianness.Big);
            var value = span.ReadUInt32BigEndian(ref cursor);
            Assert.AreEqual(4_293_568_955, value);
        }
        [TestMethod]
        public void ReadUInt32LittleEndian_ReadsCorrectly() {
            var span = GetSpan(4_293_568_955, Endianness.Little);
            var value = span.ReadUInt32LittleEndian(ref cursor);
            Assert.AreEqual(4_293_568_955, value);
        }
        [TestMethod]
        public void ReadUInt64BigEndian_ReadsCorrectly() {

            var span = GetSpan(18_378_564_784_564_235_456, Endianness.Big);
            var value = span.ReadUInt64BigEndian(ref cursor);
            Assert.AreEqual(18_378_564_784_564_235_456, value);
        }
        [TestMethod]
        public void ReadUInt64LittleEndian_ReadsCorrectly() {
            var span = GetSpan(18_378_564_784_564_235_456, Endianness.Little);
            var value = span.ReadUInt64LittleEndian(ref cursor);
            Assert.AreEqual(18_378_564_784_564_235_456, value);
        }
        [TestMethod]
        public void ReadSpan_ReadsCorrectly() {
            ReadOnlySpan<byte> span = new byte[10];
            var value = span.ReadSpan(10, ref cursor);

            Assert.AreEqual(span.Length, cursor);
            CollectionAssert.AreEqual(span.ToArray(), value.ToArray());
        }
        [TestMethod]
        public void ReadASCIIString_ReadsCorrectly() {
            var testString = "A little more than one hundred days into the fortieth year of her confinement, Dajeil Gelian was visited in her lonely tower overlooking the sea by an avatar of the great ship that was her home.";
            var bytes = Encoding.ASCII.GetBytes(testString);
            ReadOnlySpan<byte> span = bytes;
            var value = span.ReadASCIIString(testString.Length, ref cursor);

            Assert.AreEqual(testString, value);
            Assert.AreEqual(testString.Length, cursor);
        }
        [TestMethod]
        public void ReadUTF8String_ReadsCorrectly() {
            var testString = "A little more than one hundred days into the fortieth year of her confinement, Dajeil Gelian was visited in her lonely tower overlooking the sea by an avatar of the great ship that was her home.";
            var bytes = Encoding.UTF8.GetBytes(testString);
            ReadOnlySpan<byte> span = bytes;
            var value = span.ReadUTF8String(testString.Length, ref cursor);

            Assert.AreEqual(testString, value);
            Assert.AreEqual(testString.Length, cursor);
        }
        [TestMethod]

        public void TryReadInt16BigEndian_ReadsCorrectly() {
            var span = GetSpan((short)-31_971, Endianness.Big);
            if (span.TryReadInt16BigEndian(out short value, ref cursor)) {
                Assert.AreEqual(-31_971, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadInt16LittleEndian_ReadsCorrectly() {
            var span = GetSpan((short)-31_971, Endianness.Little);
            if (span.TryReadInt16LittleEndian(out short value, ref cursor)) {
                Assert.AreEqual(-31_971, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadInt32BigEndian_ReadsCorrectly() {
            var span = GetSpan(-1_598_468_598, Endianness.Big);
            if (span.TryReadInt32BigEndian(out int value, ref cursor)) {
                Assert.AreEqual(-1_598_468_598, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadInt32LittleEndian_ReadsCorrectly() {
            var span = GetSpan(-1_598_468_598, Endianness.Little);
            if (span.TryReadInt32LittleEndian(out int value, ref cursor)) {
                Assert.AreEqual(-1_598_468_598, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadInt64BigEndian_ReadsCorrectly() {
            var span = GetSpan(-7_223_372_036_854_775_808, Endianness.Big);
            if (span.TryReadInt64BigEndian(out long value, ref cursor)) {
                Assert.AreEqual(-7_223_372_036_854_775_808, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadInt64LittleEndian_ReadsCorrectly() {
            var span = GetSpan(-7_223_372_036_854_775_808, Endianness.Little);
            if (span.TryReadInt64LittleEndian(out long value, ref cursor)) {
                Assert.AreEqual(-7_223_372_036_854_775_808, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadUInt16BigEndian_ReadsCorrectly() {
            var span = GetSpan((ushort)26_598, Endianness.Big);
            if (span.TryReadUInt16BigEndian(out ushort value, ref cursor)) {
                Assert.AreEqual(26_598, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadUInt16LittleEndian_ReadsCorrectly() {
            var span = GetSpan((ushort)26_598, Endianness.Little);
            if (span.TryReadUInt16LittleEndian(out ushort value, ref cursor)) {
                Assert.AreEqual(26_598, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadUInt32BigEndian_ReadsCorrectly() {
            var span = GetSpan(4_293_568_955, Endianness.Big);
            if (span.TryReadUInt32BigEndian(out uint value, ref cursor)) {
                Assert.AreEqual(4_293_568_955, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadUInt32LittleEndian_ReadsCorrectly() {
            var span = GetSpan(4_293_568_955, Endianness.Little);
            if (span.TryReadUInt32LittleEndian(out uint value, ref cursor)) {
                Assert.AreEqual(4_293_568_955, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadUInt64BigEndian_ReadsCorrectly() {
            var span = GetSpan(18_378_564_784_564_235_456, Endianness.Big);
            if (span.TryReadUInt64BigEndian(out ulong value, ref cursor)) {
                Assert.AreEqual(18_378_564_784_564_235_456, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadUInt64LittleEndian_ReadsCorrectly() {
            var span = GetSpan(18_378_564_784_564_235_456, Endianness.Little);
            if (span.TryReadUInt64LittleEndian(out ulong value, ref cursor)) {
                Assert.AreEqual(18_378_564_784_564_235_456, value);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadSpan_ReadsCorrectly() {
            ReadOnlySpan<byte> span = new byte[10];
            if(span.TryReadSpan(out var value, 10, ref cursor)) {
                Assert.AreEqual(span.Length, cursor);
                CollectionAssert.AreEqual(span.ToArray(), value.ToArray());
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryReadASCIIString_ReadsCorrectly() {
            var testString = "A little more than one hundred days into the fortieth year of her confinement, Dajeil Gelian was visited in her lonely tower overlooking the sea by an avatar of the great ship that was her home.";
            var bytes = Encoding.ASCII.GetBytes(testString);
            ReadOnlySpan<byte> span = bytes;

            if(span.TryReadASCIIString(out var value, testString.Length, ref cursor)) {
                Assert.AreEqual(testString, value);
                Assert.AreEqual(testString.Length, cursor);
            } else {
                Assert.Fail();
            }

        }
        [TestMethod]
        public void TryReadUTF8String_ReadsCorrectly() {
            var testString = "A little more than one hundred days into the fortieth year of her confinement, Dajeil Gelian was visited in her lonely tower overlooking the sea by an avatar of the great ship that was her home.";
            var bytes = Encoding.UTF8.GetBytes(testString);
            ReadOnlySpan<byte> span = bytes;
            if(span.TryReadUTF8String(out var value, testString.Length, ref cursor)) {

                Assert.AreEqual(testString, value);
                Assert.AreEqual(testString.Length, cursor);
            } else {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TryWriteInt16BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan((short)-31_971, Endianness.Big);
            Span<byte> span = new byte[sizeof(short)];
            var succeeded = span.TryWriteInt16BigEndian(-31_971, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(short), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteInt16LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan((short)-31_971, Endianness.Little);
            Span<byte> span = new byte[sizeof(short)];
            var succeeded = span.TryWriteInt16LittleEndian(-31_971, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(short), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteInt32BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(-1_598_468_598, Endianness.Big);
            Span<byte> span = new byte[sizeof(int)];
            var succeeded = span.TryWriteInt32BigEndian(-1_598_468_598, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(int), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteInt32LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(-1_598_468_598, Endianness.Little);
            Span<byte> span = new byte[sizeof(int)];
            var succeeded = span.TryWriteInt32LittleEndian(-1_598_468_598, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(int), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteInt64BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(-7_223_372_036_854_775_808, Endianness.Big);
            Span<byte> span = new byte[sizeof(long)];
            var succeeded = span.TryWriteInt64BigEndian(-7_223_372_036_854_775_808, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(long), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteInt64LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(-7_223_372_036_854_775_808, Endianness.Little);
            Span<byte> span = new byte[sizeof(long)];
            var succeeded = span.TryWriteInt64LittleEndian(-7_223_372_036_854_775_808, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(long), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteUInt16BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan((ushort)26_598, Endianness.Big);
            Span<byte> span = new byte[sizeof(ushort)];
            var succeeded = span.TryWriteUInt16BigEndian(26_598, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(ushort), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteUInt16LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan((ushort)26_598, Endianness.Little);
            Span<byte> span = new byte[sizeof(ushort)];
            var succeeded = span.TryWriteUInt16LittleEndian(26_598, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(ushort), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteUInt32BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(4_293_568_955, Endianness.Big);
            Span<byte> span = new byte[sizeof(uint)];
            var succeeded = span.TryWriteUInt32BigEndian(4_293_568_955, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(uint), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteUInt32LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(4_293_568_955, Endianness.Little);
            Span<byte> span = new byte[sizeof(uint)];
            var succeeded = span.TryWriteUInt32LittleEndian(4_293_568_955, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(uint), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteUInt64BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(18_378_564_784_564_235_456, Endianness.Big);
            Span<byte> span = new byte[sizeof(ulong)];
            var succeeded = span.TryWriteUInt64BigEndian(18_378_564_784_564_235_456, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(ulong), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteUInt64LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(18_378_564_784_564_235_456, Endianness.Little);
            Span<byte> span = new byte[sizeof(ulong)];
            var succeeded = span.TryWriteUInt64LittleEndian(18_378_564_784_564_235_456, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(sizeof(ulong), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteSpan_WritesCorrectly() {
            Span<byte> span = new byte[10];
            var toWrite = new byte[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var succeeded = span.TryWriteSpan(toWrite, ref cursor);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(toWrite.Length, cursor);
            CollectionAssert.AreEqual(toWrite.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void TryWriteSpan_IncorrectSize_Fails() {
            Span<byte> span = new byte[1];
            var toWrite = new byte[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var succeeded = span.TryWriteSpan(toWrite, ref cursor);

            Assert.IsFalse(succeeded);

        }
        [TestMethod]
        public void TryWriteASCIIString_WritesCorrectly() {
            Span<byte> span = new byte[11];
            var toWrite = "test string";
            var succeeded = span.TryWriteASCIIString(toWrite, ref cursor);

            var encodingArray = Encoding.ASCII.GetBytes(toWrite);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(toWrite.Length, cursor);
            CollectionAssert.AreEqual(encodingArray, span.ToArray());
        }
        [TestMethod]
        public void TryWriteUTF8String_WritesCorrectly() {
            Span<byte> span = new byte[11];
            var toWrite = "test string";
            var succeeded = span.TryWriteUTF8String(toWrite, ref cursor);
            var encodingArray = Encoding.UTF8.GetBytes(toWrite);

            Assert.IsTrue(succeeded);
            Assert.AreEqual(toWrite.Length, cursor);
            CollectionAssert.AreEqual(encodingArray, span.ToArray());
        }
        [TestMethod]
        public void WriteInt16BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan((short)-31_971, Endianness.Big);
            Span<byte> span = new byte[sizeof(short)];
            span.WriteInt16BigEndian(-31_971, ref cursor);

            Assert.AreEqual(sizeof(short), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteInt16LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan((short)-31_971, Endianness.Little);
            Span<byte> span = new byte[sizeof(short)];
            span.WriteInt16LittleEndian(-31_971, ref cursor);
            
            Assert.AreEqual(sizeof(short), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteInt32BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(-1_598_468_598, Endianness.Big);
            Span<byte> span = new byte[sizeof(int)];
            span.WriteInt32BigEndian(-1_598_468_598, ref cursor);
            
            Assert.AreEqual(sizeof(int), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteInt32LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(-1_598_468_598, Endianness.Little);
            Span<byte> span = new byte[sizeof(int)];
            span.WriteInt32LittleEndian(-1_598_468_598, ref cursor);
            
            Assert.AreEqual(sizeof(int), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteInt64BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(-7_223_372_036_854_775_808, Endianness.Big);
            Span<byte> span = new byte[sizeof(long)];
            span.WriteInt64BigEndian(-7_223_372_036_854_775_808, ref cursor);
            
            Assert.AreEqual(sizeof(long), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteInt64LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(-7_223_372_036_854_775_808, Endianness.Little);
            Span<byte> span = new byte[sizeof(long)];
            span.WriteInt64LittleEndian(-7_223_372_036_854_775_808, ref cursor);
            
            Assert.AreEqual(sizeof(long), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteUInt16BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan((ushort)26_598, Endianness.Big);
            Span<byte> span = new byte[sizeof(ushort)];
            span.WriteUInt16BigEndian(26_598, ref cursor);
            
            Assert.AreEqual(sizeof(ushort), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteUInt16LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan((ushort)26_598, Endianness.Little);
            Span<byte> span = new byte[sizeof(ushort)];
            span.WriteUInt16LittleEndian(26_598, ref cursor);

            Assert.AreEqual(sizeof(ushort), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteUInt32BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(4_293_568_955, Endianness.Big);
            Span<byte> span = new byte[sizeof(uint)];
            span.WriteUInt32BigEndian(4_293_568_955, ref cursor);
            
            Assert.AreEqual(sizeof(uint), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteUInt32LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(4_293_568_955, Endianness.Little);
            Span<byte> span = new byte[sizeof(uint)];
            span.WriteUInt32LittleEndian(4_293_568_955, ref cursor);
            
            Assert.AreEqual(sizeof(uint), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteUInt64BigEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(18_378_564_784_564_235_456, Endianness.Big);
            Span<byte> span = new byte[sizeof(ulong)];
            span.WriteUInt64BigEndian(18_378_564_784_564_235_456, ref cursor);
            
            Assert.AreEqual(sizeof(ulong), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteUInt64LittleEndian_WritesCorrectly() {
            var bitConverterSpan = GetSpan(18_378_564_784_564_235_456, Endianness.Little);
            Span<byte> span = new byte[sizeof(ulong)];
            span.WriteUInt64LittleEndian(18_378_564_784_564_235_456, ref cursor);
            
            Assert.AreEqual(sizeof(ulong), cursor);
            CollectionAssert.AreEqual(bitConverterSpan.ToArray(), span.ToArray());
        }
        [TestMethod]
        public void WriteSpan_WritesCorrectly() {
            Span<byte> span = new byte[10];
            var toWrite = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            span.WriteSpan(toWrite, ref cursor);

            Assert.AreEqual(toWrite.Length, cursor);
            CollectionAssert.AreEqual(toWrite, span.ToArray());
        }
        [TestMethod]
        public void WriteASCIIString_WritesCorrectly() {
            Span<byte> span = new byte[11];
            var toWrite = "test string";
            var encodingArray = Encoding.ASCII.GetBytes(toWrite);

            span.WriteASCIIString(toWrite, ref cursor);

            Assert.AreEqual(toWrite.Length, cursor);
            CollectionAssert.AreEqual(encodingArray, span.ToArray());
        }
        [TestMethod]
        public void WriteUT8String_WritesCorrectly() {
            Span<byte> span = new byte[11];
            var toWrite = "test string";
            var encodingArray = Encoding.UTF8.GetBytes(toWrite);

            span.WriteUTF8String(toWrite, ref cursor);

            Assert.AreEqual(toWrite.Length, cursor);
            CollectionAssert.AreEqual(encodingArray, span.ToArray());
        }



        private ReadOnlySpan<byte> GetSpan(short value, Endianness endian) => CreateSpan(BitConverter.GetBytes(value), endian);
        private ReadOnlySpan<byte> GetSpan(ushort value, Endianness endian) => CreateSpan(BitConverter.GetBytes(value), endian);
        private ReadOnlySpan<byte> GetSpan(int value, Endianness endian) => CreateSpan(BitConverter.GetBytes(value), endian);
        private ReadOnlySpan<byte> GetSpan(uint value, Endianness endian) => CreateSpan(BitConverter.GetBytes(value), endian);
        private ReadOnlySpan<byte> GetSpan(long value, Endianness endian) => CreateSpan(BitConverter.GetBytes(value), endian);
        private ReadOnlySpan<byte> GetSpan(ulong value, Endianness endian) => CreateSpan(BitConverter.GetBytes(value), endian);


        private ReadOnlySpan<byte> CreateSpan(byte[] bytes, Endianness endian) {
            if (BitConverter.IsLittleEndian) {
                if (endian == Endianness.Big) {
                    bytes = bytes.Reverse().ToArray();
                }
            } else {
                if (endian == Endianness.Little) {
                    bytes = bytes.Reverse().ToArray();
                }
            }
            return new ReadOnlySpan<byte>(bytes);
        }


    }

}

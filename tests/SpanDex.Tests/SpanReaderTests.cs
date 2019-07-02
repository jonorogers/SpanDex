using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpanDex.Tests {
    [TestClass]
    public class SpanReaderTests {
        [TestMethod]
        public void ImplicitConstructors_LengthIsCorrect() {
            var byteArray = new byte[10];
            Span<byte> span = new byte[20];
            ReadOnlySpan<byte> readOnlySpan = new byte[30];

            SpanReader spanReader = byteArray;
            Assert.AreEqual(byteArray.Length, spanReader.Length);
            spanReader = span;
            Assert.AreEqual(span.Length, spanReader.Length);
            spanReader = readOnlySpan;
            Assert.AreEqual(readOnlySpan.Length, spanReader.Length);
        }
    }
}

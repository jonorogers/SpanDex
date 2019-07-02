using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpanDex.Tests {
    [TestClass]
    public class SpanWriterTests {

        [TestMethod]
        public void NullMemory_ThrowsArgumentNullException() {
            Assert.ThrowsException<ArgumentNullException>(() => {
                var spanWriter = new SpanWriter(null);
            });
        }

        [TestMethod]
        public void ImplicitConstructors_LengthIsCorrect() {
            var byteArray = new byte[10];
            Span<byte> span = new byte[20];

            SpanWriter spanWriter = byteArray;
            Assert.AreEqual(byteArray.Length, spanWriter.Length);
            spanWriter = span;
            Assert.AreEqual(span.Length, spanWriter.Length);
        }
    }
}

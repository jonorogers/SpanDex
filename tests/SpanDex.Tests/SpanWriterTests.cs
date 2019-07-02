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
    }
}

using NUnit.Framework;
using Tacklebox.Formatter;

namespace Tacklebox.Tests.Formatter
{
    [TestFixture]
    public class StringFormatTest
    {
        [Test]
        public void TestSSNFormat()
        {
            Assert.AreEqual("123-45-6789", StringFormat.SSN(123456789));
            Assert.AreEqual("123-45-6789", StringFormat.SSN("123456789"));
            Assert.AreEqual("000-45-6789", StringFormat.SSN("456789"));
            Assert.AreEqual("000-45-6789", StringFormat.SSN(456789));
        }
    }
}
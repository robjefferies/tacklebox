using NUnit.Framework;
using Tacklebox.Helper;

namespace Tacklebox.Tests.Helper
{
    [TestFixture]
    public class NumberHelperTest
    {
        [Test]
        public void Int32ParseWithNull()
        {
            Assert.AreEqual(null,NumberHelper.Int32ParseWithNull(""));
            Assert.AreEqual(null,NumberHelper.Int32ParseWithNull(null));
            Assert.AreEqual(-1, NumberHelper.Int32ParseWithNull("-1"));
        }
    }
}

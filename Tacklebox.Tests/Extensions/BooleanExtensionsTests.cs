using NUnit.Framework;
using Tacklebox.Extensions;

namespace Tacklebox.Tests.Extensions
{
    [TestFixture]
    public class BooleanExtensionsTests
    {
        [Test]
        public void ToInt32()
        {
            Assert.AreEqual(1,true.ToInt32());
            Assert.AreEqual(0,false.ToInt32());
        }
    }
}
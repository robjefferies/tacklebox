using System;
using Tacklebox.Extensions;
using NUnit.Framework;

namespace Tacklebox.Tests.Extensions
{
    [TestFixture]
    public class DateTimeExtensionTests
    {
        [Test]
        public void MinTest()
        {
            DateTime earlier = new DateTime(2012, 04, 05);
            DateTime later = new DateTime(2012, 04, 10);

            Assert.AreEqual(earlier, earlier.Min(later));
            Assert.AreEqual(earlier, later.Min(earlier));
        }

        [Test]
        public void MaxTest()
        {
            DateTime earlier = new DateTime(2012, 04, 05);
            DateTime later = new DateTime(2012, 04, 10);

            Assert.AreEqual(later, earlier.Max(later));
            Assert.AreEqual(later, later.Max(earlier));
        }
    }
}
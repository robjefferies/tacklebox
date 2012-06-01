using System;
using NUnit.Framework;
using Tacklebox.Helper;

namespace Tacklebox.Tests.Helper
{
    [TestFixture]
    public class DateHelperTest
    {
        [Test]
        public void AgeTest()
        {
            DateTime birthday = new DateTime(1980, 1, 1);

            Assert.AreEqual(0,DateHelper.Age(birthday,birthday)); // Same Day
            Assert.AreEqual(1, DateHelper.Age(birthday, birthday.AddYears(1))); // One Year
            Assert.AreEqual(0,DateHelper.Age(birthday,birthday.AddYears(1).AddDays(-1))); // One day less than a year
            Assert.AreEqual(10,DateHelper.Age(birthday,birthday.AddYears(10).AddMonths(1).AddDays(3))); // 10 year, 1 month , 3 dys

        }
    }
}
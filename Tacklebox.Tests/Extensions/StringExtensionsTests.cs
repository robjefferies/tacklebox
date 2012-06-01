﻿using System;
using NUnit.Framework;
using Tacklebox.Extensions;

namespace Tacklebox.Tests.Extensions
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void TestToInt32()
        {
            Assert.AreEqual(3,"3".ToInt32());
            Assert.AreEqual(-3,"-3".ToInt32());
        }

        [Test]
        public void TestToDouble()
        {
            var first = "3.3".ToDouble();
            Assert.AreEqual(typeof (double), first.GetType());
            Assert.AreEqual(3.3m, first);
            Assert.AreEqual(-3.3m, "-3.3".ToDouble());
            Assert.AreEqual(0m,"0".ToDouble());
        }

        [Test]
        public void TestToBoolean()
        {
            Assert.AreEqual(true,"Y".ToBool());
            Assert.AreEqual(false,"N".ToBool());
            Assert.AreEqual(true,"YES".ToBool());
            Assert.AreEqual(false,"NO".ToBool());
            Assert.AreEqual(true,"T".ToBool());
            Assert.AreEqual(false,"F".ToBool());
            Assert.AreEqual(true,"TRUE".ToBool());
            Assert.AreEqual(false,"FALSE".ToBool());

            Assert.AreEqual(true, "y".ToBool());
            Assert.AreEqual(false, "n".ToBool());
            Assert.AreEqual(true, "yes".ToBool());
            Assert.AreEqual(false, "no".ToBool());
            Assert.AreEqual(true, "t".ToBool());
            Assert.AreEqual(false, "f".ToBool());
            Assert.AreEqual(true, "true".ToBool());
            Assert.AreEqual(false, "false".ToBool());

            Assert.AreEqual(true,"1".ToBool());
            Assert.AreEqual(false,"0".ToBool());
        }

        [Test]
        public void TestToDateTime()
        {
            Assert.AreEqual(new DateTime(2012,4,28),"4/28/2012".ToDateTime());
        }
    }
}
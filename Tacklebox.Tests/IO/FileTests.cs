using System.Collections.Generic;
using NUnit.Framework;

namespace Tacklebox.Tests.IO
{
    [TestFixture]
    class FileTests
    {
        [Test]
        public void TestDeleteSilent()
        {
            const string FILENAME = "test-file.txt";

            var lines = new List<string>() { "One","Two","three"};
            System.IO.File.WriteAllLines(FILENAME, lines);

            // Test delete when the file should exist
            Assert.AreEqual(true, System.IO.File.Exists(FILENAME));
            Tacklebox.IO.File.DeleteSilent(FILENAME);
            Assert.AreEqual(false, System.IO.File.Exists(FILENAME));

            // Test delete when the file should not exist
            Assert.AreEqual(false, System.IO.File.Exists(FILENAME));
            Tacklebox.IO.File.DeleteSilent(FILENAME);
            Assert.AreEqual(false, System.IO.File.Exists(FILENAME));

        }
    }
}

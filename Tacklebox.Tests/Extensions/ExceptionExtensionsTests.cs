using System;
using Tacklebox.Extensions;
using NUnit.Framework;

namespace Tacklebox.Tests.Extensions
{
    [TestFixture]
    public class ExceptionExtensionsTests
    {
        [Test]
         public void TestInnermost()
         {
             try
             {
                 Level1();
             } catch(Exception ex)
             {
                 var innermost = ex.Innermost();
                 Assert.AreEqual("Level 3 Exception", innermost.Message);
             }
         }

        [Test]
        public void TestMessageList()
        {
            try
            {
                Level1();
            } catch(Exception ex)
            {
                var messageList = ex.MessageList();
                Assert.AreEqual(3, messageList.Count);
                Assert.Contains("Level 1 Exception",messageList);
                Assert.Contains("Level 2 Exception", messageList);
                Assert.Contains("Level 3 Exception", messageList);
            }
        }

        private void Level3()
        {
            throw new ApplicationException("Level 3 Exception");
        }
        private void Level2()
        {
            try
            {
                Level3();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Level 2 Exception",ex);
            }
        }
        private void Level1()
        {
            try
            {
                Level2();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Level 1 Exception", ex);
            }
        }
    }
}
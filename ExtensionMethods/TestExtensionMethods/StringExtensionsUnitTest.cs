using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common.Extensions;
namespace TestExtensionMethods
{
    [TestClass]
    public class StringExtensionsUnitTest
    {
        [TestMethod]
        public void TestBasicString()
        {
            var source = "";
            var a = source.IsEmpty();
            Assert.IsTrue(source.IsEmpty(), "failed");

        }
    }
}

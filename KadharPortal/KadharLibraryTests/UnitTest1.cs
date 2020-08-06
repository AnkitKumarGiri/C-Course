using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KadharLibrary;
namespace KadharLibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testInstance = new Kadhar();
            var testResult = testInstance.ReadFile();
            Console.WriteLine(testResult);
            Assert.IsTrue(testResult.StartsWith("This"));
        }
    }
}

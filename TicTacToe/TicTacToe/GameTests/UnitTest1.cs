using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLibrary;
namespace GameTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testInstance = new Game();
            var testResult = testInstance.getWinner();
            Assert.AreEqual(-2, testResult, "Expected -1");
        }
    }
}

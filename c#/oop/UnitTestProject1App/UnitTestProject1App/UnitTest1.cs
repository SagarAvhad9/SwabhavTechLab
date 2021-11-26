using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1App
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UnitTestProject1App.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace addressbook_web_tests.Other
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] s = new string[] { "I", "want", "to", "sleep" };

            //for (int i = 0; i < s.Length; i++)
            foreach (string element in s)
            {
                System.Console.Out.Write(element + "\n");
            }
        }
    }
}

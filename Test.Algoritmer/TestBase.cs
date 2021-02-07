using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer
{
    [TestClass]
    public class TestBase
    {
        protected static void AssertOutput(string[] expectedArray, IReadOnlyList<string> actualArray)
        {
            Assert.AreEqual(expectedArray.Length, actualArray.Count, "Expected and actual are not the same length");
            int index = 0;
            foreach (string expected in expectedArray)
            {
                Assert.AreEqual(expected, actualArray[index], $"Wrong at index {index}{Environment.NewLine}");
                index++;
            }
        }
    }
}
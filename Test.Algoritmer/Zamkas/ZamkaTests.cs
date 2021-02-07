using System;
using System.Collections.Generic;
using System.Text;
using Algoritmer.Zamkas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.Zamkas
{
    [TestClass]
    public class ZamkaTests : TestBase
    {
        [TestMethod]
        public void TestOne()
        {
            string[] input = { "1", "100", "4" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "4", "40" };

            Zamka.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TestTwo()
        {
            string[] input = { "100", "500", "12" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "129", "480" };

            Zamka.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TestThree()
        {
            string[] input = { "1", "10000", "1" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "1", "10000" };

            Zamka.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

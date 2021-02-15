﻿using Algoritmer.CatchThePlanes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.CatchThePlanes
{
    [TestClass]
    public class CatchThePlaneTests : TestBase
    {
        [TestMethod]
        public void TestOne()
        {
            string[] input = { "8 4", "1000", "0 1 0 900 0.2", "0 2 100 500 1.0", "2 1 500 700 1.0", "2 1 501 701 0.1", "0 3 200 400 0.5", "3 1 500 800 0.1", "3 0 550 650 0.9", "0 1 700 900 0.1" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "0.3124" };

            CatchThePlane.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TestTwo()
        {
            string[] input = { "4 2", "2", "0 1 0 1 0.5", "0 1 0 1 0.5", "0 1 1 2 0.4", "0 1 1 2 0.2" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "0.7" };

            CatchThePlane.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

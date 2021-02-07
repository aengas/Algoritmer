using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Algoritmer.SpeedLimits;

namespace Test.Algoritmer.SpeedLimits
{
    [TestClass]
    public class SpeedLimitTests
    {
        [TestMethod]
        public void OneGroup_OneInput()
        {
            string[] input = { "1", "20 2", "-1" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "40 miles" };

            SpeedLimit.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void OneGroup_ThreeInputs()
        {
            string[] input = { "1", "20 2", "30 6", "10 7", "-1" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "170 miles" };

            SpeedLimit.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void ThreeGroups_DifferentInputs()
        {
            string[] input = { "1", "20 2", "30 6", "10 7", "2", "60 1", "30 5", "3", "15 1", "25 2", "30 3", "10 5", "-1" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "170 miles", "180 miles", "90 miles" };

            SpeedLimit.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        private static void AssertOutput(string[] expectedArray, IReadOnlyList<string> actualArray)
        {
            int index = 0;
            foreach (string expected in expectedArray)
            {
                Assert.AreEqual(expected, actualArray[index], $"Wrong at index {index}");
                index++;
            }
        }
    }
}

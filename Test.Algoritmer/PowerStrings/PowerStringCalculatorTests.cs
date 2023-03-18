using Algoritmer.PowerStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.PowerStrings
{
    [TestClass]
    public class PowerStringCalculatorTests : TestBase
    {
        [TestMethod]
        public void TestOne()
        {
            string[] input = { "abcd", "aaaa", "ababab", "." };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "1", "4", "3" };

            PowerStringCalculator.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

    }
}

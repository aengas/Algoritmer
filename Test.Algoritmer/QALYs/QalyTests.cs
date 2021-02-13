using Algoritmer.QALYs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.QALYs
{
    [TestClass]
    public class QalyTests : TestBase
    {
        [TestMethod]
        public void OneLine()
        {
            string[] input = { "1", "1.0 12.0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "12.000" };

            Qaly.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TwoLines()
        {
            string[] input = { "2", "1.0 3.0", "2.0 5.0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "13.000" };

            Qaly.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void FiveLines()
        {
            string[] input = { "5", "1.0 12.0", "0.7 5.2", "0.9 10.7", "0.5 20.4", "0.2 30.0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "41.470" };

            Qaly.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

using Algoritmer.HappyTelephones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.HappyTelephones
{
    [TestClass]
    public class HappyTelephoneTests : TestBase
    {
        [TestMethod]
        public void OneCall_OneIntervalInCall()
        {
            string[] input = { "1 1", "1 2 0 10", "1 2", "0 0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "1" };

            HappyTelephone.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void OneCall_OneIntervalOnBeginningOfCall()
        {
            string[] input = { "1 1", "1 2 0 10", "0 2", "0 0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "1" };

            HappyTelephone.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void OneCall_OneIntervalOnEndOfCall()
        {
            string[] input = { "1 1", "1 2 0 10", "9 1", "0 0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "1" };

            HappyTelephone.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void OneCall_OneIntervalSpanningWholeOfCall()
        {
            string[] input = { "1 1", "1 2 0 10", "0 10", "0 0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "1" };

            HappyTelephone.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TwoCalls_TwoIntervals_OneIntervalWithTwoCalls_OneIntervalWithOneCall()
        {
            string[] input = { "2 2", "3 4 2 5", "1 2 0 10", "0 6", "8 2", "0 0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "2", "1" };

            HappyTelephone.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void SampleInputOne()
        {
            string[] input = { "3 2", "3 4 2 5", "1 2 0 10", "6 5 5 8", "0 6", "8 2", "1 2", "8 9 0 10", "9 10", "10 1", "0 0"};
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "3", "2", "1", "0" };

            HappyTelephone.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

using Algoritmer.CardTradings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.CardTradings
{
    [TestClass]
    public class CardTradingTests : TestBase
    {
        [TestMethod]
        public void SampleInput1()
        {
            string[] input = { "4 3 2", "1 3 2 1", "1 50", "50 20", "40 30" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "10" };

            CardTrading.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void SampleInput2()
        {
            string[] input = { "4 3 2", "1 3 2 1", "1 20", "50 20", "40 30" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "-20" };

            CardTrading.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

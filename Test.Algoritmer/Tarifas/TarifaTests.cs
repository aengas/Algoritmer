using Algoritmer.Tarifas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.Tarifas
{
    [TestClass]
    public class TarifaTests : TestBase
    {
        [TestMethod]
        public void TestOne()
        {
            string[] input = { "10", "3", "4", "6", "2" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "28" };

            Tarifa.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TestTwo()
        {
            string[] input = { "10", "3", "10", "2", "12" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "16" };

            Tarifa.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TestThree()
        {
            string[] input = { "15", "3", "15", "10", "20" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "15" };

            Tarifa.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

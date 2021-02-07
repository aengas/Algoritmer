using Algoritmer.SodaSlurpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.SodaSlurpers
{
    [TestClass]
    public class SodaSlurperTests : TestBase
    {
        [TestMethod]
        public void StartOne_FoundZero_PriceTwo_DrinkZero()
        {
            string[] input = { "1 0 2" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "0" };

            SodaSlurper.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void StartTwo_FoundZero_PriceTwo_DrinkOne()
        {
            string[] input = { "2 0 2" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "1" };

            SodaSlurper.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void StartThree_FoundZero_PriceTwo_DrinkTwo()
        {
            string[] input = { "3 0 2" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "2" };

            SodaSlurper.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
        
        [TestMethod]
        public void StartFour_FoundZero_PriceTwo_DrinkThree()
        {
            string[] input = { "4 0 2" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "3" };

            SodaSlurper.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void SampleInputOne()
        {
            string[] input = { "9 0 3" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "4" };

            SodaSlurper.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void SampleInputTwo()
        {
            string[] input = { "5 5 2" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "9" };

            SodaSlurper.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

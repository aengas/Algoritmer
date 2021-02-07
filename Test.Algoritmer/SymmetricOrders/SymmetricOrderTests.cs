using Algoritmer.SymmetricOrders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.SymmetricOrders
{
    [TestClass]
    public class SymmetricOrderTests : TestBase
    {
        [TestMethod]
        public void OneSet_TwoNames()
        {
            string[] input = { "2", "Bo", "Pat", "0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "SET 1", "Bo", "Pat" };

            SymmetricOrder.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void OneSet_SixNames()
        {
            string[] input = { "6", "Bo", "Pat", "Jean", "Kevin", "Claude", "William", "0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "SET 1", "Bo", "Jean", "Claude", "William", "Kevin", "Pat" };

            SymmetricOrder.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void OneSet_SevenNames()
        {
            string[] input = { "7", "Bo", "Pat", "Jean", "Kevin", "Claude", "William", "Marybeth", "0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "SET 1", "Bo", "Jean", "Claude", "Marybeth", "William", "Kevin", "Pat" };

            SymmetricOrder.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void ThreeSets_DifferentAmountOfNames()
        {
            string[] input = { "7", "Bo", "Pat", "Jean", "Kevin", "Claude", "William", "Marybeth", "6", "Jim", "Ben", "Zoe", "Joey", "Frederick", "Annabelle", "5", "John", "Bill", "Fran", "Stan", "Cece", "0" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "SET 1", "Bo", "Jean", "Claude", "Marybeth", "William", "Kevin", "Pat", "SET 2", "Jim", "Zoe", "Frederick", "Annabelle", "Joey", "Ben", "SET 3", "John", "Fran", "Cece", "Stan", "Bill" };

            SymmetricOrder.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

using Algoritmer.JoinStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.JoinStrings
{
    [TestClass]
    public class JoinStringsTests : TestBase
    {
        [TestMethod]
        public void Test1()
        {
            string[] input = { "4", "cute", "cat", "kattis", "is", "3 2", "4 1", "3 4" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "kattiscatiscute" };

            JoinStringsCalculator.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void Test2()
        {
            string[] input = { "3", "howis", "this", "practicalexam", "1 2", "1 3" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "howisthispracticalexam" };

            JoinStringsCalculator.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

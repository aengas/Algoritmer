using Algoritmer.SpellingBees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.SpellingBees
{
    [TestClass]
    public class SpellingBeeTests : TestBase
    {
        [TestMethod]
        public void OneInDictionary_OneTrue()
        {
            string[] input = { "drulyag", "1", "dryad" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "dryad" };

            SpellingBee.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TwoInDictionary_TwoTrue()
        {
            string[] input = { "drulyag", "2", "dryad", "duly" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "dryad", "duly" };

            SpellingBee.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void ThreeInDictionary_TwoTrue()
        {
            string[] input = { "drulyag", "3", "dryad", "duly", "spelling" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "dryad", "duly" };

            SpellingBee.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void FourInDictionary_TwoTrue()
        {
            string[] input = { "drulyag", "4", "dryad", "duly", "spelling", "multiplexed" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "dryad", "duly" };

            SpellingBee.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void FiveInDictionary_TwoTrue()
        {
            string[] input = { "drulyag", "5", "dryad", "duly", "spelling", "multiplexed", "janna" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "dryad", "duly" };

            SpellingBee.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void SixInDictionary_ThreeTrue()
        {
            string[] input = { "drulyag", "6", "dryad", "duly", "spelling", "multiplexed", "janna", "lard" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "dryad", "duly", "lard" };

            SpellingBee.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void SevenInDictionary_ThreeTrue()
        {
            string[] input = { "drulyag", "7", "dryad", "duly", "spelling", "multiplexed", "janna", "lard", "dryly" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "dryad", "duly", "lard", "dryly" };

            SpellingBee.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void EigthInDictionary_FourTrue()
        {
            string[] input = { "drulyag", "8", "dryad", "duly", "spelling", "multiplexed", "janna", "lard", "dryly", "lallygag" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "dryad", "duly", "lard", "dryly" };

            SpellingBee.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void NineInDictionary_FourTrue()
        {
            string[] input = { "drulyag", "9", "dryad", "duly", "spelling", "multiplexed", "janna", "lard", "dryly", "lallygag", "a" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "dryad", "duly", "lard", "dryly" };

            SpellingBee.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TenInDictionary_FiveTrue()
        {
            string[] input = { "drulyag", "10", "dryad", "duly", "spelling", "multiplexed", "janna", "lard", "dryly", "lallygag", "a", "rad" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "dryad", "duly", "lard", "dryly" };

            SpellingBee.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

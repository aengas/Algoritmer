using Algoritmer.CastingSpells;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.CastingSpells
{
    [TestClass]
    public class CastingSpellsTests : TestBase
    {
        [TestMethod]
        public void SampleInput1()
        {
            string[] input = { "abrahellehhelleh" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "12" };

            CastingSpell.Calculate(consoleFaker);
            int i = 1;
            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void Test3()
        {
            string[] input = { "abcdeffedcbahellehhelleh" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "12" };

            CastingSpell.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void Test5()
        {
            string[] input = { "xabcdefgihellehhellehigfedcbay" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "12" };

            CastingSpell.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

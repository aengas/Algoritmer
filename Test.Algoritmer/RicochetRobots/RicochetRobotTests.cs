using Algoritmer.RicochetRobots;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.RicochetRobots
{
    [TestClass]
    public class RicochetRobotTests : TestBase
    {
        [TestMethod]
        public void FirstSample()
        {
            /*
2 5 4 10
.2...
...W.
WWW..
.X.1.
             */


            string[] input = { "2 5 4 10", ".2...", "...W.", "WWW..", ".X.1." };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "6" };

            RicochetRobot.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void SecondSample()
        {
            /*
1 5 4 10
.....
...W.
WWW..
.X.1.
             */


            string[] input = { "1 5 4 10", ".....", "...W.", "WWW..", ".X.1." };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "6" };

            RicochetRobot.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

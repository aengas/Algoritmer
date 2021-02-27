using Algoritmer.CourseSchedulers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algoritmer.CourseSchedulers
{
    [TestClass]
    public class CourseSchedulerTests : TestBase
    {
        [TestMethod]
        public void OneStudent_OneCourse()
        {
            string[] input = { "1", "PINK TIE CS241" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "CS241 1" };

            CourseScheduler.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TwoStudents_OneCourse()
        {
            string[] input = { "2", "PINK TIE CS241", "JOHN DOE CS241" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "CS241 2" };

            CourseScheduler.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TwoStudents_TwoCourse()
        {
            string[] input = { "3", "PINK TIE CS241", "JOHN DOE CS241", "JOHN DOE CSS" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "CS241 2", "CSS 1" };

            CourseScheduler.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }

        [TestMethod]
        public void TwoStudents_OneDuplicate_TwoCourse()
        {
            string[] input = { "4", "PINK TIE CS241", "JOHN DOE CS241", "JOHN DOE CSS", "JOHN DOE CSS" };
            var consoleFaker = new ConsoleFaker(input);
            string[] expected = { "CS241 2", "CSS 1" };

            CourseScheduler.Calculate(consoleFaker);

            AssertOutput(expected, consoleFaker.Output);
        }
    }
}

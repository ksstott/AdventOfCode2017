using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advent2017.Tests
{
    [TestClass]
    public class Day6Tests
    {
        [TestMethod]
        public void SolvePart1_Example_FiveReturned()
        {
            // Arrange
            string input = "0\t2\t7\t0";
            Day6 day6 = new Day6();

            // Act
            int result = day6.SolvePart1(input);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SolvePart2_Example_FourReturned()
        {
            // Arrange
            string input = "0\t2\t7\t0";
            Day6 day6 = new Day6();

            // Act
            int result = day6.SolvePart2(input);

            // Assert
            Assert.AreEqual(4, result);
        }
    }
}

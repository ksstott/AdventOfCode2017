using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advent2017.Tests
{
    [TestClass]
    public class Day8Tests
    {
        [TestMethod]
        public void SolvePart1_Example_LargestValueReturned()
        {
            // Arrange
            string input = @"b inc 5 if a > 1
a inc 1 if b < 5
c dec -10 if a >= 1
c inc -20 if c == 10";
            Day8 day8 = new Day8();

            // Act
            int result = day8.SolvePart1(input);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SolvePart2_Example_FourReturned()
        {
            // Arrange
            string input = @"b inc 5 if a > 1
a inc 1 if b < 5
c dec -10 if a >= 1
c inc -20 if c == 10";
            Day8 day8 = new Day8();

            // Act
            int result = day8.SolvePart2(input);

            // Assert
            Assert.AreEqual(10, result);
        }
    }
}

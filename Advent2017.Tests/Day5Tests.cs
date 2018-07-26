using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Advent2017.Tests
{
    [TestClass]
    public class Day5Tests
    {
        [TestMethod]
        public void SolvePart1_Example_FiveReturned()
        {
            // Arrange
            string jumpOffsets = @"0
3
0
1
-3";
            Day5 day5 = new Day5();

            // Act
            int result = day5.SolvePart1(jumpOffsets);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SolvePart2_Example_TenReturned()
        {
            // Arrange
            string jumpOffsets = @"0
3
0
1
-3";
            Day5 day5 = new Day5();

            // Act
            int result = day5.SolvePart2(jumpOffsets);

            // Assert
            Assert.AreEqual(10, result);
        }
    }
}

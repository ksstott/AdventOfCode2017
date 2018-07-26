using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Advent2017.Tests
{
    [TestClass]
    public class Day2Tests
    {
        [TestMethod]
        public void CalculatePart1_OneRow_TwoReturned()
        {
            // Arrange
            Day2 classUnderTest = new Day2();
            string spreadsheet = "1 2   3";

            // Act
            int result = classUnderTest.CalculatePart1(spreadsheet);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CalculatePart1_TwoRows_SevenReturned()
        {
            // Arrange
            Day2 classUnderTest = new Day2();
            string spreadsheet = @"1    2   3
6   2   1";

            // Act
            int result = classUnderTest.CalculatePart1(spreadsheet);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void CalculatePart2_OneRow_TwoReturned()
        {
            // Arrange
            Day2 classUnderTest = new Day2();
            string spreadsheet = "2 3   4";

            // Act
            int result = classUnderTest.CalculatePart2(spreadsheet);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CalculatePart2_TwoRows_TenReturned()
        {
            // Arrange
            Day2 classUnderTest = new Day2();
            string spreadsheet = @"2    7   14
6   2   7";

            // Act
            int result = classUnderTest.CalculatePart2(spreadsheet);

            // Assert
            Assert.AreEqual(10, result);
        }
    }
}

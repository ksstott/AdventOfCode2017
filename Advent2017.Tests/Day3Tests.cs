using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Advent2017.Tests
{
    [TestClass]
    public class Day3Tests
    {
        [TestMethod]
        public void SolvePart1_FullGridSixteen_ReturnThree()
        {
            // Arrange
            Day3 day3 = new Day3();
            int squareNumber = 16;

            // Act
            int result = day3.SolvePart1(squareNumber);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SolvePart1_NewColumnGridEighteen_ReturnThree()
        {
            // Arrange
            Day3 day3 = new Day3();
            int squareNumber = 18;

            // Act
            int result = day3.SolvePart1(squareNumber);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SolvePart1_NewRowGridTwentyFour_ReturnThree()
        {
            // Arrange
            Day3 day3 = new Day3();
            int squareNumber = 24;

            // Act
            int result = day3.SolvePart1(squareNumber);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SolvePart2_TwentyFour_ReturnTwentyFive()
        {
            // Arrange
            Day3 day3 = new Day3();
            int squareNumber = 24;

            // Act
            int result = day3.SolvePart2(squareNumber);

            // Assert
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void SolvePart2_FiftyFive_ReturnFiftySeven()
        {
            // Arrange
            Day3 day3 = new Day3();
            int squareNumber = 55;

            // Act
            int result = day3.SolvePart2(squareNumber);

            // Assert
            Assert.AreEqual(57, result);
        }
    }
}

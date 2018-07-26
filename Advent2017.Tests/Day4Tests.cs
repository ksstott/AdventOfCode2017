using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Advent2017.Tests
{
    [TestClass]
    public class Day4Tests
    {
        [TestMethod]
        public void SolvePart1_SingleValidPhrase_OneReturned()
        {
            // Arrange
            string words = "aa bb cc";
            Day4 day4 = new Day4();

            // Act
            int result = day4.SolvePart1(words);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SolvePart1_SingleInValidPhrase_ZeroReturned()
        {
            // Arrange
            string words = "aa bb cc bb";
            Day4 day4 = new Day4();

            // Act
            int result = day4.SolvePart1(words);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SolvePart1_SingleInValidOneValidPhrase_OneReturned()
        {
            // Arrange
            string words = @"aa bb cc bb
aa bb cc";
            Day4 day4 = new Day4();

            // Act
            int result = day4.SolvePart1(words);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SolvePart2_SingleValidPhrase_OneReturned()
        {
            // Arrange
            string words = "aa bb cc";
            Day4 day4 = new Day4();

            // Act
            int result = day4.SolvePart2(words);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SolvePart2_SingleInValidPhrase_ZeroReturned()
        {
            // Arrange
            string words = "ab bb cc ba";
            Day4 day4 = new Day4();

            // Act
            int result = day4.SolvePart2(words);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}

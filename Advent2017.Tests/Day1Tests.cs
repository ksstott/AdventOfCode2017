using Microsoft.VisualStudio.TestTools.UnitTesting;
using Advent2017;

namespace Advent2017.Tests
{
    [TestClass]
    public class Day1Tests
    {
        [TestMethod]
        public void SolvePart1_NoMatchingNumbers_Zero()
        {
            // Arrange
            string captcha = "0123456789";
            Day1 day1 = new Day1();

            // Act
            int result = day1.SolvePart1(captcha);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SolvePart1_OneMatchingNumber_ThreeReturned()
        {
            // Arrange
            string captcha = "0123356789";
            Day1 day1 = new Day1();

            // Act
            int result = day1.SolvePart1(captcha);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SolvePart1_OneMatchingNumberAtEnd_OneReturned()
        {
            // Arrange
            string captcha = "1723456781";
            Day1 day1 = new Day1();

            // Act
            int result = day1.SolvePart1(captcha);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SolvePart1_TwoMatchingNumbers_FourReturned()
        {
            // Arrange
            string captcha = "1123356789";
            Day1 day1 = new Day1();

            // Act
            int result = day1.SolvePart1(captcha);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SolvePart1_TwoMatchingNumbersOneAtEnd_FourReturned()
        {
            // Arrange
            string captcha = "1723356781";
            Day1 day1 = new Day1();

            // Act
            int result = day1.SolvePart1(captcha);

            // Assert
            Assert.AreEqual(4, result);
        }



        [TestMethod]
        public void SolvePart2_NoMatchingNumbers_Zero()
        {
            // Arrange
            string captcha = "0123456789";
            Day1 day1 = new Day1();

            // Act
            int result = day1.SolvePart2(captcha);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SolvePart2_OneMatchingNumber_SixReturned()
        {
            // Arrange
            string captcha = "323456345678";
            Day1 day1 = new Day1();

            // Act
            int result = day1.SolvePart2(captcha);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void SolvePart2_OneMatchingNumberAtEnd_TwoReturned()
        {
            // Arrange
            string captcha = "0723156781";
            Day1 day1 = new Day1();

            // Act
            int result = day1.SolvePart2(captcha);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SolvePart2_TwoMatchingNumbers_EightReturned()
        {
            // Arrange
            string captcha = "1234516389";
            Day1 day1 = new Day1();

            // Act
            int result = day1.SolvePart2(captcha);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void SolvePart2_TwoMatchingNumbersOneAtEnd_EightReturned()
        {
            // Arrange
            string captcha = "1723316783";
            Day1 day1 = new Day1();

            // Act
            int result = day1.SolvePart2(captcha);

            // Assert
            Assert.AreEqual(8, result);
        }
    }
}

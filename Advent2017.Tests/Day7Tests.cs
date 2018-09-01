using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advent2017.Tests
{
    [TestClass]
    public class Day7Tests
    {
        [TestMethod]
        public void SolvePart1_Example_BottomNameReturned()
        {
            // Arrange
            string input = @"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (72) -> ktlj, cntj, xhth
qoyq (66)
padx (45) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (68) -> gyxo, ebii, jptl
gyxo (61)
cntj (57)";
            Day7 day7 = new Day7();

            // Act
            string result = day7.SolvePart1(input);

            // Assert
            Assert.AreEqual("tknk", result);
        }

        [TestMethod]
        public void SolvePart2_Example_FourReturned()
        {
            // Arrange
            string input = @"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (72) -> ktlj, cntj, xhth
qoyq (66)
padx (45) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (68) -> gyxo, ebii, jptl
gyxo (61)
cntj (57)";
            Day7 day7 = new Day7();

            // Act
            int result = day7.SolvePart2(input);

            // Assert
            Assert.AreEqual(60, result);
        }
    }
}

using System;
using System.Linq;

namespace Advent2017
{
    public class Day5
    {
        public int SolvePart1(string jumpOffsets)
        {
            int[] jumps = jumpOffsets.Split('\n').Select(int.Parse).ToArray();
            int numberOfJumps = 0;
            int currentIndex = 0;
            while (currentIndex >= 0 && currentIndex < jumps.Length)
            {
                numberOfJumps++;
                currentIndex += jumps[currentIndex]++;
            }

            return numberOfJumps;
        }

        public int SolvePart2(string jumpOffsets)
        {
            int[] jumps = jumpOffsets.Split('\n').Select(int.Parse).ToArray();
            int numberOfJumps = 0;
            int currentIndex = 0;
            while (currentIndex >= 0 && currentIndex < jumps.Length)
            {
                numberOfJumps++;
                int jump = jumps[currentIndex];
                if (jump >= 3)
                {
                    jumps[currentIndex]--;
                }
                else
                {
                    jumps[currentIndex]++;
                }
                currentIndex += jump;
            }

            return numberOfJumps;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent2017
{
    public class Day6
    {
        public int SolvePart1(string jumpOffsets)
        {
            int[] blocks = jumpOffsets.Split('\t').Select(int.Parse).ToArray();
            HashSet<string> previousCombinations = new HashSet<string>();

            int i = 0;
            while(!previousCombinations.Contains(string.Join("\t", blocks.Select(x => x.ToString()))))
            {
                previousCombinations.Add(string.Join("\t", blocks.Select(x => x.ToString())));
                RedistributeBlocks(blocks);
                i++;
            }

            return i;
        }

        public int SolvePart2(string jumpOffsets)
        {
            int[] blocks = jumpOffsets.Split('\t').Select(int.Parse).ToArray();
            HashSet<string> previousCombinations = new HashSet<string>();

            while (!previousCombinations.Contains(string.Join("\t", blocks.Select(x => x.ToString()))))
            {
                previousCombinations.Add(string.Join("\t", blocks.Select(x => x.ToString())));
                RedistributeBlocks(blocks);
            }

            string combinationToFind = string.Join("\t", blocks.Select(x => x.ToString()));
            int i = 0;
            do
            {
                RedistributeBlocks(blocks);
                i++;
            } while (combinationToFind != string.Join("\t", blocks.Select(x => x.ToString())));
            return i;
        }
                
        private static void RedistributeBlocks(int[] blocks)
        {
            int largestBlock = blocks.Max();
            int indexOfMax = Array.IndexOf(blocks, largestBlock);
            blocks[indexOfMax] = 0;
            for (int j = indexOfMax + 1; largestBlock > 0; j++)
            {
                j = j == blocks.Length ? 0 : j;
                blocks[j]++;
                largestBlock--;
            }
        }
    }
}
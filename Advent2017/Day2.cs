using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent2017
{
    public class Day2
    {
        public int CalculatePart1(string spreadsheet)
        {
            IEnumerable<IEnumerable<int>> spreadsheetArrays = spreadsheet.Split('\n').Select(rowString => rowString.Split(new [] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            return spreadsheetArrays.Sum(row => row.Max() - row.Min());
        }

        public int CalculatePart2(string spreadsheet)
        {
            IEnumerable<IEnumerable<int>> spreadsheetArrays = spreadsheet.Split('\n').Select(rowString => rowString.Split(new[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            return spreadsheetArrays.Sum(GetWholeDivisibleNumberFromRow);
        }

        private int GetWholeDivisibleNumberFromRow(IEnumerable<int> row)
        {
            int[] rowArray = row.ToArray();
            for (int i = 0; i < rowArray.Length; i++)
            {
                int a = rowArray[i];
                for (int j = 0; j < rowArray.Length; j++)
                {
                    if (i != j)
                    {
                        int b = rowArray[j];
                        if (a != b)
                        {
                            if (a > b && a % b == 0)
                            {
                                return a / b;
                            }
                            else if (a < b && b % a == 0)
                            {
                                return b / a;
                            }
                        }
                    }
                }
            }

            return 0;
        }
    }
}

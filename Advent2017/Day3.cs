using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent2017
{
    public class Day3
    {
        public int SolvePart1(int squareNumber)
        {
            GridSize gridSize = CalculateGridSize(squareNumber);

            int largestSide = Math.Max(gridSize.X, gridSize.Y);
            int secondSide = Math.Min(gridSize.X, gridSize.Y);

            int positionOfMiddleOfSecondSide = secondSide / 2;
            int positionOfSquareOnNewRowColumn = secondSide - 1 - ((gridSize.X * gridSize.Y) - squareNumber);

            return (largestSide/2) + Math.Abs(positionOfMiddleOfSecondSide - positionOfSquareOnNewRowColumn);
        }

        private GridSize CalculateGridSize(int squareNumber)
        {
            GridSize gridSize = new GridSize();

            while (gridSize.X * gridSize.Y < squareNumber)
            {
                gridSize.X++;
                if (gridSize.X * gridSize.Y > squareNumber)
                {
                    break;
                }

                gridSize.Y++;
            }

            return gridSize;
        }

        private class GridSize
        {
            public int X { get; set; } = 1;

            public int Y { get; set; } = 1;
        }

        public int SolvePart2(int squareNumber)
        {
            List<List<int?>> grid = new List<List<int?>> { new List<int?> { 1 } };
            int x = 0;
            int y = 0;
            while (grid[y][x] < squareNumber)
            {
                if(grid.All(row => row.All(z => z.HasValue))) // Grid is full, need a new row/column
                {
                    if (y == 0 && x == grid[0].Count-1 && grid.Count == grid[0].Count) // We're in the bottom right corner, add a column to the right
                    {
                        grid.ForEach(row => row.Add(null));
                        x++;
                    }
                    else if(y == grid.Count-1 && x == grid[0].Count - 1) // We're in the top right corner, add a row to the top
                    {
                        grid.Add(grid[0].Select(_ => (int?)null).ToList());
                        y++;
                    }
                    else if(y == grid.Count - 1 && x == 0) // We're in the top left corner, add a column to the left
                    {
                        grid.ForEach(row => row.Insert(0, null));
                    }
                    else // We're in the bottom left corner, add a row to the bottom
                    {
                        grid.Insert(0, grid[0].Select(_ => (int?)null).ToList());
                    }
                }
                else if (grid[y].Any(z => z == null)) // There are empty values on the row, move along.
                {
                    if (grid.Count % 2 == 1) // Odd number of rows, adding left to right
                    {
                        x++;
                    }
                    else // Even number of rows, adding right to left
                    {
                        x--;
                    }
                }
                else // We need to move up and down a row
                {
                    if (grid[0].Count % 2 == 0) // Even number of columns, adding bottom to top
                    {
                        y++;
                    }
                    else // Odd number of rows, adding top to bottom
                    {
                        y--;
                    }
                }

                grid[y][x] = GetNextNumber(x, y, grid);
            }

            return grid[y][x].Value;
        }

        private int GetNextNumber(int x, int y, List<List<int?>> grid)
        {
            int result = 0;
            if (x > 0) // We have a square to the left
            {
                result += grid[y][x - 1].GetValueOrDefault();
            }
            if (y > 0) // We have a square below
            {
                result += grid[y - 1][x].GetValueOrDefault();
            }
            if (x < grid[y].Count-1) // We have a square to the right
            {
                result += grid[y][x + 1].GetValueOrDefault();
            }
            if (y < grid.Count-1) // We have a square above
            {
                result += grid[y + 1][x].GetValueOrDefault();
            }

            if (x > 0 && y > 0) // We have a square below and to the left
            {
                result += grid[y - 1][x - 1].GetValueOrDefault();
            }
            if (x < grid[y].Count-1 && y > 0) // We have a square below and to the right
            {
                result += grid[y - 1][x + 1].GetValueOrDefault();
            }
            if (y < grid.Count-1 && x > 0) // We have a square above and to the left
            {
                result += grid[y + 1][x - 1].GetValueOrDefault();
            }
            if (y < grid.Count-1 && x < grid[y].Count-1) // We have a square above and to the right
            {
                result += grid[y + 1][x + 1].GetValueOrDefault();
            }

            return result;
        }
    }
}

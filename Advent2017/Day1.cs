using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent2017
{
    public class Day1
    {
        public int SolvePart1(string captchaNumbers)
        {
            if (captchaNumbers.Length > 1)
            {
                List<int> numbersMatchingNextNumber = new List<int>();
                int i = 0;
                char number = captchaNumbers[i];
                char nextNumber;
                do
                {
                    if (i == captchaNumbers.Length - 1)
                    {
                        nextNumber = captchaNumbers[0];
                    }
                    else
                    {
                        nextNumber = captchaNumbers[i + 1];
                    }
                    if (number == nextNumber)
                    {
                        numbersMatchingNextNumber.Add(int.Parse(number.ToString()));
                    }

                    number = nextNumber;
                    i++;
                } while (i < captchaNumbers.Length);

                return numbersMatchingNextNumber.Sum();
            }

            return 0;
        }

        public int SolvePart2(string captchaNumbers)
        {
            if (captchaNumbers.Length > 1)
            {
                List<int> numbersMatchingNextNumber = new List<int>();
                int i = 0;
                do
                {
                    char number = captchaNumbers[i];
                    int nextIndex = i + (captchaNumbers.Length / 2);
                    if (nextIndex > captchaNumbers.Length - 1)
                    {
                        nextIndex -= captchaNumbers.Length;
                    }
                    char nextNumber = captchaNumbers[nextIndex];
                    if (number == nextNumber)
                    {
                        numbersMatchingNextNumber.Add(int.Parse(number.ToString()));
                    }
                    
                    i++;
                } while (i < captchaNumbers.Length);

                return numbersMatchingNextNumber.Sum();
            }

            return 0;
        }
    }
}
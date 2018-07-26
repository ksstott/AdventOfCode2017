using System;
using System.Linq;

namespace Advent2017
{
    public class Day4
    {
        public int SolvePart1(string phrases)
        {
            string[] phrasesArray = phrases.Split('\n');
            return phrasesArray.Count(IsValidPhrase);
        }

        private bool IsValidPhrase(string phrase)
        {
            string[] words = phrase.Trim().Split(' ');
            return words.Length == words.Distinct().Count();
        }

        public int SolvePart2(string phrases)
        {
            string[] phrasesArray = phrases.Split('\n');
            return phrasesArray.Count(IsValidPhrase2);
        }
        
        private bool IsValidPhrase2(string phrase)
        {
            string[] words = phrase.Trim().Split(' ').Select(s => new string(s.OrderBy(c => c).ToArray())).ToArray();
            return words.Length == words.Distinct().Count();
        }
    }
}

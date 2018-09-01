using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent2017
{
    public class Day7
    {
        public string SolvePart1(string input)
        {
            string[] programsAndDecendants = input.Split('\n');
            List<string> programNames = programsAndDecendants.Select(p => p.Substring(0, p.IndexOf(' '))).ToList();

            foreach (string[] decendants in programsAndDecendants.Where(p => p.Contains("->")).Select(x => x.Substring(x.IndexOf("->") + 3).Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)))
            {
                foreach (var decendant in decendants)
                {
                    programNames.Remove(decendant.Trim());
                }
            }

            return programNames[0];
        }

        public int SolvePart2(string input)
        {
            string[] towerStrings = input.Split('\n');
            List<Tower> towers = new List<Tower>();
            foreach (string towerString in towerStrings)
            {
                string parentProgram = towerString.Substring(0, towerString.IndexOf(' '));
                int indexOfWeight = towerString.IndexOf('(')+1;
                int indexOfCloseBracket = towerString.IndexOf(')');
                int weight = int.Parse(towerString.Substring(indexOfWeight, indexOfCloseBracket- indexOfWeight));
                string[] decendants;
                if (towerString.Contains("->"))
                {
                    decendants = towerString.Substring(towerString.IndexOf("->") + 3).Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    decendants = decendants.Select(d => d.Trim()).ToArray();
                }
                else
                {
                    decendants = new string[0];
                }
                towers.Add(new Tower(towers, parentProgram, weight, decendants));
            }

            var unBalancedTowersGroupedByWeight = towers
                .First(t => !t.IsBalanced && t.AreTowersBalanced)
                .Towers.GroupBy(t => t.Weight);
            int maxWeight = unBalancedTowersGroupedByWeight.Max(g => g.Key);
            Tower towerToChangeWeight = unBalancedTowersGroupedByWeight.Single(tg => tg.Key == maxWeight).Single();
            Tower towerToCompareWeight = unBalancedTowersGroupedByWeight.Single(tg => tg.Key != maxWeight).First();

            return towerToChangeWeight.ParentProgramWeight - (towerToChangeWeight.Weight - towerToCompareWeight.Weight);
        }

        private class Tower
        {
            public Tower(IEnumerable<Tower> towers, string patentProgram, int parentWeight, string[] decendants)
            {
                this.towers = towers;
                this.ParentProgram = patentProgram;
                this.ParentProgramWeight = parentWeight;
                this.decendants = decendants;
            }
            private string[] decendants;
            private IEnumerable<Tower> towers;

            public string ParentProgram { get; private set; }
            public int ParentProgramWeight { get; private set; }

            public IEnumerable<Tower> Towers => this.towers.Where(t => this.decendants.Contains(t.ParentProgram));
            public int Weight => this.ParentProgramWeight + this.Towers.Sum(t => t.Weight);
            public bool AreTowersBalanced => this.Towers.All(t => t.IsBalanced);
            public bool IsBalanced => this.Towers.Select(t => t.Weight).Distinct().Count() <= 1;
            public override string ToString()
            {
                return $"{this.ParentProgram} ({this.ParentProgramWeight}) -> {string.Join(", ", this.decendants)}";
            }
        }
    }
}
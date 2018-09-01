using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent2017
{
    public class Day8
    {
        public int SolvePart1(string input)
        {
            string[] instructions = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> registers = new Dictionary<string, int>();

            foreach (string instruction in instructions)
            {
                string[] instructionParts = instruction.Split(' ');
                if (!registers.ContainsKey(instructionParts[0]))
                {
                    registers.Add(instructionParts[0], 0);
                }
                if (!registers.ContainsKey(instructionParts[4]))
                {
                    registers.Add(instructionParts[4], 0);
                }

                if(ShouldPerformInstruction(instructionParts, registers))
                {
                    ProcessInstruction(instructionParts, registers);
                }
            }

            return registers.Max(p => p.Value);
        }

        public int SolvePart2(string input)
        {
            int maxValue = 0;
            string[] instructions = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> registers = new Dictionary<string, int>();

            foreach (string instruction in instructions)
            {
                string[] instructionParts = instruction.Split(' ');
                if (!registers.ContainsKey(instructionParts[0]))
                {
                    registers.Add(instructionParts[0], 0);
                }
                if (!registers.ContainsKey(instructionParts[4]))
                {
                    registers.Add(instructionParts[4], 0);
                }

                if (ShouldPerformInstruction(instructionParts, registers))
                {
                    ProcessInstruction(instructionParts, registers);
                }

                maxValue = Math.Max(maxValue, registers.Max(x => x.Value));
            }

            return maxValue;
        }

        private void ProcessInstruction(string[] instructionParts, Dictionary<string, int> registers)
        {
            switch (instructionParts[1])
            {
                case "inc":
                    registers[instructionParts[0]] += int.Parse(instructionParts[2]);
                    break;
                case "dec":
                    registers[instructionParts[0]] -= int.Parse(instructionParts[2]);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private bool ShouldPerformInstruction(string[] instructionParts, Dictionary<string, int> registers)
        {
            int registerValue = registers[instructionParts[4]];
            int valueToCompare = int.Parse(instructionParts[6]);
            switch (instructionParts[5])
            {
                case ">":
                    return registerValue > valueToCompare;
                case "<":
                    return registerValue < valueToCompare;
                case ">=":
                    return registerValue >= valueToCompare;
                case "<=":
                    return registerValue <= valueToCompare;
                case "==":
                    return registerValue == valueToCompare;
                case "!=":
                    return registerValue != valueToCompare;
            }

            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using SharedKernel.Input;

namespace Day3.Solution
{
    public static class RucksackReorganization
    {
        public static void Execute()
        {
            var data = FileReadInput.GetInstance().Load();
            
            // Find the item type that appears in both compartments of each rucksack.
            // What is the sum of the priorities of those item types?
            Console.WriteLine($"Part 1 is {Part1(data)}");
            // Find the item type that corresponds to the badges of each three-Elf group.
            // What is the sum of the priorities of those item types?
            Console.WriteLine($"Part 2 is {Part2(data)}");
        }

        private static int Part2(string[] data)
        {
            var priorities = new List<int>();
            string joined;
            int iMax;
            HashSet<char> uniques;
            for (int i = 0; i < data.Length; i+=3)
            {
                iMax = data[i].Length > data[i + 2].Length
                    ? data[i].Length > data[i + 1].Length ? i : i + 1 : i + 2;
                uniques = new HashSet<char>(data[iMax]);
                foreach (var curr in uniques)
                {
                    if (data[i].Contains(curr) && data[i + 1].Contains(curr) && data[i + 2].Contains(curr))
                    {
                        priorities.Add(GetPriority(curr));
                        break;
                    }
                }
            }
            
            return priorities.Sum();
        }

        private static int Part1(string[] data)
        {
            var priorities = new List<int>();
            (string Comp1, string Comp2) comps;
            char curr;
            foreach (var rucksack in data)
            {
                var len = rucksack.Length / 2;
                comps = (rucksack.Substring(0, len), rucksack.Substring(len, len));
                for (int i = 0; i < comps.Comp1.Length; i++)
                {
                    curr = comps.Comp1[i];
                    if (comps.Comp2.Contains(curr))
                    {
                        priorities.Add(GetPriority(curr));
                        break;
                    }
                }
            }

            return priorities.Sum();
        }

        private static int GetPriority(char c)
        {
            if (char.IsUpper(c))
            {
                return c - 38;
            }
            return c - 96;
        }
    }
}
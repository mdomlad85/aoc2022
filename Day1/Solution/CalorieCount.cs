using System;
using System.Linq;
using SharedKernel.Input;

namespace Day1.Solution;

public static class CalorieCount
{
    public static void Execute()
    {
        var data = FileReadInput.GetInstance().Load();
        var top3 = new int[3];
        var curr = 0;
        foreach (var row in data)
        {
            if (string.IsNullOrEmpty(row))
            {
                for (var i = 0; i < top3.Length; i++)
                {
                    if (curr > top3[i])
                    {
                        top3[i] = curr;
                        Array.Sort(top3);
                        break;
                    }
                }
                curr = 0;
            }
            else
            {
                curr += int.Parse(row);
            }
        }
        // Find the Elf carrying the most Calories. How many total Calories is that Elf carrying?
        Console.WriteLine($"Part 1 is {top3.Last()}");
        // Find the top three Elves carrying the most Calories. How many Calories are those Elves carrying in total?
        Console.WriteLine($"Part 2 is {top3.Sum()}");
    }
}
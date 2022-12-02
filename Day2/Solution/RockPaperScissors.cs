using System;
using System.Collections.Generic;
using System.Linq;
using SharedKernel.Input;

namespace Day2.Solution;

public class RockPaperScissors
{
    public static void Execute()
    {
        var data = FileReadInput.GetInstance().Load();
        (int part1, int part2) sums = (0, 0);
        foreach (var line in data)
        {
            sums.part1 += Combinations[line].part1;
            sums.part2 += Combinations[line].part2;
        }
        // What would your total score be if everything goes exactly according to your strategy guide?
        Console.WriteLine($"Part 1 is {sums.part1}");
        // Following the Elf's instructions for the second column, what would your total score be if
        // everything goes exactly according to your strategy guide?
        Console.WriteLine($"Part 2 is {sums.part2}");
    }

    private static Dictionary<string, (int part1, int part2)> Combinations =>
        new()
        {
            { "A X", (4, 3) },
            { "A Y", (8, 4) },
            { "A Z", (3, 8) },
            { "B X", (1, 1) },
            { "B Y", (5, 5) },
            { "B Z", (9, 9) },
            { "C X", (7, 2) },
            { "C Y", (2, 6) },
            { "C Z", (6, 7) },
        };
}
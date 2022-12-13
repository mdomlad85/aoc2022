using System;
using System.Linq;
using SharedKernel.Input;

namespace Day5.Solution;

public static class SupplyStacks
{
    public static void Execute()
    {
        var data = FileReadInput.GetInstance().Load();

        var crates = data.TakeWhile(line => !string.IsNullOrEmpty(line)).Reverse().ToArray();
        var crateMover9000 = new CargoBaseMover9000(crates);
        var crateMover9001 = new CargoBaseMover9001(crates);
        var moves = data.SkipWhile(line => !line.Contains("move"));
        foreach (var move in moves)
        {
            crateMover9000.Move(move);
            crateMover9001.Move(move);
        }
        // After the rearrangement procedure completes, what crate ends up on top of each stack?
        Console.WriteLine($"Part 1 is {crateMover9000.TopStack()}");
        // After the rearrangement procedure completes, what crate ends up on top of each stack?
        Console.WriteLine($"Part 2 is {crateMover9001.TopStack()}");
    }
}
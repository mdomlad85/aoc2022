using System;
using SharedKernel.Input;

namespace Day4.Solution;

public static class CampCleanup
{
    public static void Execute()
    {
        var data = FileReadInput.GetInstance().Load();

        string[] elfsSection;
        Elf elf1, elf2;
        int intersectionsCount = 0, overlapsCount = 0;
        foreach (var line in data)
        {
            elfsSection = line.Split(',');
            elf1 = new Elf(elfsSection[0].Split('-'));
            elf2 = new Elf(elfsSection[1].Split('-'));
            
            if (elf1.FullyContains(elf2)) intersectionsCount++;
            if (elf1.Overlaps(elf2)) overlapsCount++;
        }
        // In how many assignment pairs does one range fully contain the other?
        Console.WriteLine($"Part 1 is {intersectionsCount}");
        // In how many assignment pairs do the ranges overlap?
        Console.WriteLine($"Part 2 is {overlapsCount}");
    }
}
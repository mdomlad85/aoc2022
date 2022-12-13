namespace Day4.Solution;

public static class Extensions
{
    public static bool FullyContains(this Elf elf1, Elf elf2)
    {
        if (elf1.Length > elf2.Length)
        {
            return elf1.Start <= elf2.Start && elf1.End >= elf2.End;
        }
        return elf2.Start <= elf1.Start && elf2.End >= elf1.End;
    }
    public static bool Overlaps(this Elf elf1, Elf elf2)
    {
        return !((elf1.End < elf2.Start && elf1.Start < elf2.End) ||
                 (elf2.End < elf1.Start && elf2.Start < elf1.End));
    }
}
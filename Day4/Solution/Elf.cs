using System.Text;

namespace Day4.Solution;

public class Elf
{
    public int Start { get; }
    public int End { get; }
    public int Length => End - Start + 1;

    public Elf(string[] elf)
    {
        Start = int.Parse(elf[0]);
        End = int.Parse(elf[1]);
    }
}
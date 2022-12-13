using System.Collections.Generic;

namespace Day5.Solution;

public class CargoBaseMover9001 : CargoBase
{
    public CargoBaseMover9001(string[] input) : base(input) {}

    public override void Move(string command)
    {
        var m = CommandStrip.Match(command);
        var howMany = int.Parse(m.Groups[1].Value);
        var fromKey = int.Parse(m.Groups[2].Value);
        var toKey = int.Parse(m.Groups[3].Value);
        var cratesToMove = new Stack<char>();
        for (int i = 0; i < howMany; i++)
        {
           cratesToMove.Push(Crates[fromKey].Pop());
        }
        foreach (var crate in cratesToMove)
        {
            Crates[toKey].Push(crate);
        }        
    }
}
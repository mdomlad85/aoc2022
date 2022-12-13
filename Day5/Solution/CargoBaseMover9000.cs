namespace Day5.Solution;

public class CargoBaseMover9000 : CargoBase
{
    public CargoBaseMover9000(string[] input) : base(input) {}

    public override void Move(string command)
    {
        var m = CommandStrip.Match(command);
        var howMany = int.Parse(m.Groups[1].Value);
        var fromKey = int.Parse(m.Groups[2].Value);
        var toKey = int.Parse(m.Groups[3].Value);
        for (int i = 0; i < howMany; i++)
        {
            Crates[toKey].Push(Crates[fromKey].Pop());
        }
    }
}
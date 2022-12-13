using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day5.Solution;

public abstract class CargoBase
{
    protected Dictionary<int, Stack<char>> Crates { get; } = new();
    protected readonly Regex CommandStrip = new Regex(@"move (\d+) from (\d+) to (\d+)", RegexOptions.Singleline);

    protected CargoBase(string[] input)
    {
        var keys = input[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (var key in keys)
        {
            Crates[int.Parse(key)] = new Stack<char>();
        }

        for (int i = 1; i < input.Length; i++)
        {
            var crates = Regex.Split(input[i], @"\s{1,4}");
            
            foreach (var key in Crates.Keys)
            {
                var crate = crates[key - 1];
                if (!string.IsNullOrEmpty(crate)) Crates[key].Push(crate[1]);
            }
        }
    }

    public abstract void Move(string command);

    public string TopStack()
    {
        var topStack = new StringBuilder();
        foreach (var crate in Crates)
        {
            topStack.Append(crate.Value.Peek());
        }

        return topStack.ToString();
    }
}
using System;
using System.Collections.Generic;

namespace DESIGNPATTERNS.CSharp_Example.StrategyPattern
{

    public override void Sort(List<string> list)
    {
        //list.ShellSort();  not-implemented
        Console.WriteLine("ShellSorted list ");
    }
}
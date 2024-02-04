.using System;

namespace DESIGNPATTERNS.CSharp_Example.BuilderPattern
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------List Of Toys--------------------------------------------");

        var toyACreator = new ToyCreator(new ToyABuilder());
        toyACreator.CreateToy();
        toyACreator.GetToy().Dump();

        var toyBCreator = new ToyCreator(new ToyBBuilder());
        toyBCreator.CreateToy();
        toyBCreator.GetToy().Dump();
    }

}
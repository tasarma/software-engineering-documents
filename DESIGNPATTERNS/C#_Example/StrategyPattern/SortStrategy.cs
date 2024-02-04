using System.Collections.Generic;

namespace DESIGNPATTERNS.CSharp_Example.StrategyPattern
{

    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
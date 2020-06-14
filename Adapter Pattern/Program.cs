using System;
using System.Collections.Generic;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> AllDucks = new List<Duck>();

            AllDucks.Add(new MallardDuck());
            AllDucks.Add(new MallardDuck());

            Turkey turkey = new WildTurkey();
            AllDucks.Add(new TurkeyAdpater(turkey));

            foreach (var duck in AllDucks)
            {
                duck.Quack();
            }
        }
    }
}

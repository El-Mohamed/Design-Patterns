using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso();
            beverage.Size = BeverageSize.TALL;
            System.Console.WriteLine(beverage.GetDescription());
            System.Console.WriteLine(beverage.Cost());
            System.Console.WriteLine("\n");
            beverage = new Mocha(beverage);
            System.Console.WriteLine(beverage.GetDescription());
            System.Console.WriteLine(beverage.Cost());
        }
    }
}

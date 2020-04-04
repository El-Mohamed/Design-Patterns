using System;

namespace Template_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeineBeverage tea = new Tea();
            CaffeineBeverage coffee = new Coffee();

            tea.PrepareReceipe();
            System.Console.WriteLine("\n");
            coffee.PrepareReceipe();
        }
    }
}

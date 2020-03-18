using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Can't do this
            //Singleton1 s1 = new Singleton1(); 

            // The "GetInstace" is not a method

            People.GetInstance.MakeOlder();
            People.GetInstance.ShowAge();
        }
    }
}

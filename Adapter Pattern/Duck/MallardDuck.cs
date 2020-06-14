namespace Adapter_Pattern
{
    public class MallardDuck : Duck
    {
        public void Fly()
        {
            System.Console.WriteLine("Fly Long Distance");
        }

        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}
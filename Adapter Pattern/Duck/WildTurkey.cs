namespace Adapter_Pattern
{
    public class WildTurkey : Turkey
    {
        public void Fly()
        {
            System.Console.WriteLine("Fly Short Distance");
        }

        public void Gobble()
        {
            System.Console.WriteLine("Gobble");
        }
    }
}
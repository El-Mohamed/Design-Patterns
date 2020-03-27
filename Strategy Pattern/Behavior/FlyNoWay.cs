namespace Strategy_Pattern
{

    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I Can't Fly");
        }
    }
}
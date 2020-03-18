namespace Strategy_Pattern
{
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("I Can't Quack!");
        }
    }
}
namespace Strategy_Pattern
{
    public class SpecialDuck : Duck
    {
        public SpecialDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }
    }
}
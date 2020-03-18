namespace Strategy_Pattern
{
    public class NormalDuck : Duck
    {
        public NormalDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
    }
}
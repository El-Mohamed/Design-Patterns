namespace Strategy_Pattern
{
    public class Duck
    {
        public FlyBehavior flyBehavior { get; set; }
        public QuackBehavior quackBehavior { get; set; }

        public Duck()
        {

        }

        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void performFly()
        {
            flyBehavior.fly();
        }
    }
}
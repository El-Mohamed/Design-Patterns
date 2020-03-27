namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalDuck normalDuck = new NormalDuck();
            SpecialDuck specialDuck = new SpecialDuck();

            normalDuck.performFly();
            normalDuck.performQuack();

            specialDuck.performFly();
            specialDuck.performQuack();
        }
    }
}

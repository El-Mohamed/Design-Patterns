namespace Template_Method_Pattern
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            System.Console.WriteLine("Add Lemon");
        }

        public override void Brew()
        {
            System.Console.WriteLine("Steeping the tea");
        }
    }
}
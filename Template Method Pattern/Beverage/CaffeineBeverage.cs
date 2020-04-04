namespace Template_Method_Pattern
{
    public abstract class caffeineBeverage
    {
        public void PrepareReceipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        public void BoilWater()
        {
            System.Console.WriteLine("Boiling Water");
        }

        public void PourInCup()
        {
            System.Console.WriteLine("Pouring into Cup");
        }
    }
}
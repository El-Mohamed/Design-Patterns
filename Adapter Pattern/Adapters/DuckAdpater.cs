namespace Adapter_Pattern
{
    public class DuckAdpater : Turkey
    {
        private Duck duck;
        public DuckAdpater(Duck duck)
        {
            this.duck = duck;
        }

        public void Fly()
        {
            duck.Fly();
        }

        public void Gobble()
        {
            duck.Quack();
        }
    }
}
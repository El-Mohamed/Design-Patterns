namespace Adapter_Pattern
{
    public class TurkeyAdpater : Duck
    {
        private Turkey turkey;
        public TurkeyAdpater(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            turkey.Fly();
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
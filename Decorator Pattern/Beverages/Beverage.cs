namespace Decorator_Pattern
{
    public abstract class Beverage
    {
        public BeverageSize Size { get; set; }
        public abstract double Cost();

        public virtual string GetDescription()
        {
            return "Unknown Beverage";
        }
    }
}
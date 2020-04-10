using System;

namespace Decorator_Pattern
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return GetSize(base.Size);
        }

        public double GetSize(BeverageSize size)
        {
            switch (size)
            {
                case BeverageSize.TALL:
                    return Convert.ToDouble("0.10") +
                        beverage.Cost();
                case BeverageSize.GRANDE:
                    return Convert.ToDouble("0.15") +
                        beverage.Cost();
                case BeverageSize.VENTI:
                    return Convert.ToDouble("0.20") +
                        beverage.Cost();
                default:
                    return 0.20;
            }
        }
    }
}
using System;

namespace Observer_Pattern
{
    class Exchange
    {
        static void Main(string[] args)
        {
            PriceData priceData = new PriceData();

            CurrentPriceDisplay currentPriceDisplay = new CurrentPriceDisplay(priceData);

            priceData.SetData(100, 200);
            currentPriceDisplay.Display();
            priceData.SetData(110, 210);
            currentPriceDisplay.Display();
        }
    }
}

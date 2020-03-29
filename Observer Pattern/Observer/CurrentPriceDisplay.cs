namespace Observer_Pattern
{
    public class CurrentPriceDisplay : Observer, DisplayElement
    {
        private float price;
        private float volume;
        private Subject priceData;

        public CurrentPriceDisplay(Subject priceData)
        {
            this.priceData = priceData;
            priceData.registerObserver(this);
        }

        // Display Interface
        public void Display()
        {
            System.Console.WriteLine("CURRENT DATA");
            System.Console.WriteLine("=====================");
            System.Console.WriteLine($"Current Price: {price} EUR");
            System.Console.WriteLine($"Current Volume: {volume} EUR");
            System.Console.WriteLine("=====================\n");
        }

        // Observer Interface
        public void Update(float price, float volume)
        {
            this.price = price;
            this.volume = volume;
        }
    }
}
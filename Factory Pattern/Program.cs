namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChicagoPizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            chicagoPizzaStore.OrderPizza("cheese");

            NYPizzaStore nYPizzaStore = new NYPizzaStore();
            nYPizzaStore.OrderPizza("cheese");
        }
    }
}

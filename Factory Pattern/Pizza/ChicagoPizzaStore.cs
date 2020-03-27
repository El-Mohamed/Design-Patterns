namespace Factory_Pattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore()
        { 

		}
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else return null;
        }
    }
}

namespace Factory_Pattern
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore()
        {

        }

        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else return null;
        }
    }
}

using System.Collections;

namespace Factory_Pattern
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected ArrayList toppings = new ArrayList();

        public Pizza()
        {

        }

        public abstract void Prepare();

        public void Bake()
        {
            System.Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            System.Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            System.Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return name;
        }
    }
}

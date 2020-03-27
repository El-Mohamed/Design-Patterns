namespace Factory_Pattern
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Martinara Sauce";

            toppings.Add("Greated Reggiano Cheese");
        }

        public override void Prepare()
        {
            System.Console.WriteLine("Preparing Pizza...");
        }
    }
}

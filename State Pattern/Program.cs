namespace State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            // Car is stopped in constructor

            myCar.Drive();
            myCar.Drive();

            myCar.Brake();
            myCar.Brake();

        }
    }
}

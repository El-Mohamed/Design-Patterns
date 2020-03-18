namespace State_Pattern
{
    public class StoppedState : State
    {
        public void Brake()
        {
            System.Console.WriteLine("Car already braking");
        }

        public void Drive()
        {
            System.Console.WriteLine("Car starts driving...");
        }
    }
}
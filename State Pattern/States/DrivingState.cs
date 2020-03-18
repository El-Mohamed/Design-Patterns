namespace State_Pattern
{
    public class DrivingState : State
    {
        public void Brake()
        {
            System.Console.WriteLine("Car is breaking.....");
        }

        public void Drive()
        {
            System.Console.WriteLine("Car is already driving");
        }
    }
}
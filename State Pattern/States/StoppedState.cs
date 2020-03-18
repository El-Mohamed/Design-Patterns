namespace State_Pattern
{
    public class StoppedState : State
    {
        Car car;

        public StoppedState(Car car)
        {
            this.car = car;
        }

        public void Brake()
        {
            System.Console.WriteLine("Car already braking");
        }

        public void Drive()
        {
            System.Console.WriteLine("Car starts driving...");
            car.setState(car.drivingState);
        }
    }
}
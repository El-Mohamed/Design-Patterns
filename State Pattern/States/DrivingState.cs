namespace State_Pattern
{
    public class DrivingState : State
    {
        Car car;

        public DrivingState(Car car)
        {
            this.car = car;
        }

        public void Brake()
        {
            System.Console.WriteLine("Car is breaking.....");
            car.setState(car.stoppedState);
            // car.state = car.stoppedState
        }

        public void Drive()
        {
            System.Console.WriteLine("Car is already driving");
        }
    }
}
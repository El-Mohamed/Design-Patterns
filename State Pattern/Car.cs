namespace State_Pattern
{
    public class Car
    {
        public State stoppedState { get; set; }
        public State drivingState { get; set; }
        public State state { get; set; }

        public Car()
        {
            stoppedState = new StoppedState(this);
            drivingState = new DrivingState(this);

            state = stoppedState;
        }

        public void Drive()
        {
            state.Drive();
        }

        public void Brake()
        {
            state.Brake();
        }

        // This method is not needed 
        public void setState(State state)
        {
            this.state = state;
        }

    }
}
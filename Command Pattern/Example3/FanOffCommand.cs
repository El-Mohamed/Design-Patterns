namespace Command_Pattern
{
    public class FanOffCommand : Command
    {
        Fan ceilingFan;
        int previousSpeed;

        public FanOffCommand(Fan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void execute()
        {
            previousSpeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
        }

        public void undo()
        {
            if (previousSpeed == Fan.HIGH)
            {
                ceilingFan.High();
            }
            else if (previousSpeed == Fan.MEDUIM)
            {
                ceilingFan.Meduim();
            }
            else if (previousSpeed == Fan.LOW)
            {
                ceilingFan.Low();
            }
            else if (previousSpeed == Fan.OFF)
            {
                ceilingFan.Off();
            }
        }
    }
}
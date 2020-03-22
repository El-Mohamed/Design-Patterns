namespace Command_Pattern
{
    public class FanMeduimCommand : Command
    {
        Fan ceilingFan;
        int previousSpeed;

        public FanMeduimCommand(Fan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void execute()
        {
            previousSpeed = ceilingFan.GetSpeed();
            ceilingFan.Meduim();
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
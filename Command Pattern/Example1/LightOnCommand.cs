namespace Command_Pattern
{
    public class LightOnCommand : Command
    {
        LightBulb lightBulb;

        public LightOnCommand(LightBulb lightBulb)
        {
            this.lightBulb = lightBulb;
        }

        public void execute()
        {
            lightBulb.On();
        }
    }
}
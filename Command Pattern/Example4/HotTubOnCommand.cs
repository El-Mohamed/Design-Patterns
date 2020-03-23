namespace Command_Pattern
{
    public class HotTubOnCommand : Command
    {
        HotTub hotTub;
        public HotTubOnCommand(HotTub hotTub)
        {
            this.hotTub = hotTub;
        }

        public void execute()
        {
            hotTub.On();
        }

        public void undo()
        {
            hotTub.Off();
        }
    }
}
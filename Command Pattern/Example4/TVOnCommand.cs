namespace Command_Pattern
{
    public class TVOnCommand : Command
    {
        RoomTV tv;

        public TVOnCommand(RoomTV tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
            tv.On();
        }

        public void undo()
        {
            tv.Off();
        }
    }
}
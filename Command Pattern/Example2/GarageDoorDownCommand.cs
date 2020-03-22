namespace Command_Pattern
{
    public class GarageDoorDownCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void execute()
        {
            garageDoor.Down();
        }

        public void undo()
        {
            garageDoor.Up();
        }
    }
}
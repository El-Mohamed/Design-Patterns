namespace Command_Pattern
{
    public class GarageDoorUpCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void execute()
        {
            garageDoor.Up();
        }

        public void undo()
        {
            garageDoor.Down();
        }
    }
}
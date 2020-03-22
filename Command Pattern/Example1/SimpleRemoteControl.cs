namespace Command_Pattern
{
    public class SimpleRemoteControl
    {
        Command slot;

        public SimpleRemoteControl()
        {

        }

        public void SetCommand(Command command)
        {
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.execute();
        }
    }
}
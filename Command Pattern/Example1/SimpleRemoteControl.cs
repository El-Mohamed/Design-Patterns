namespace Command_Pattern
{
    public class SimpleRemoteControl
    {
        Command slot;
        Command undoCommand;

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
            undoCommand = slot;
        }

        public void UndoButtonWasPressed()
        {
            undoCommand.undo();
        }
    }
}
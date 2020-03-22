namespace Command_Pattern
{
    public class AdvancedRemote
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;
        public AdvancedRemote()
        {
            onCommands = new Command[2];
            offCommands = new Command[2];
            Command noCommand = new NoCommand();

            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, Command onCommand, Command ofCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = ofCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPressed()
        {
            undoCommand.undo();
        }
    }
}
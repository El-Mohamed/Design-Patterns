namespace Command_Pattern
{

    public class MacroCommand : Command
    {
        Command[] commands;
        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void execute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].execute();
            }
        }

        public void undo()
        {
            //throw new System.NotImplementedException();
        }
    }

}
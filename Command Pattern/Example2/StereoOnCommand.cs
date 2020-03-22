namespace Command_Pattern
{
    public class StereoOnCommand : Command
    {
        Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.On();
        }
    }
}
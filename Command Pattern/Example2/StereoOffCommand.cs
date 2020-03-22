namespace Command_Pattern
{
    public class StereoOffCommand : Command
    {
        Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.Off();
        }

        public void undo()
        {
            stereo.On();
        }
    }
}
using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            SimpleRemoteControl remote = new SimpleRemoteControl();         // Invoker
            LightBulb light = new LightBulb();                              // Receiver
            LightOnCommand lightOnCommand = new LightOnCommand(light);      // Command
            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();

            // Example 2
            AdvancedRemote remote2 = new AdvancedRemote();

            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo();

            GarageDoorUpCommand garageDoorUpCommand = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDownCommand = new GarageDoorDownCommand(garageDoor);

            StereoOnCommand stereoOnCommand = new StereoOnCommand(stereo);
            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);

            remote2.SetCommand(0, garageDoorUpCommand, garageDoorDownCommand);
            remote2.SetCommand(1, stereoOnCommand, stereoOffCommand);

            remote2.OnButtonWasPressed(0);
            remote2.OnButtonWasPressed(1);
            remote2.OffButtonWasPressed(0);
            remote2.OffButtonWasPressed(1);
        }
    }
}

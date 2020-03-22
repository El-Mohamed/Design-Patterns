using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)                                     // Client
        {
            // Example 1
            SimpleRemoteControl remote = new SimpleRemoteControl();         // Invoker
            LightBulb light = new LightBulb();                              // Receiver
            LightOnCommand lightOnCommand = new LightOnCommand(light);      // Command
            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();
            remote.UndoButtonWasPressed();

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

            remote2.UndoButtonWasPressed();

            Example 3

            AdvancedRemote remote3 = new AdvancedRemote();

            Fan fan = new Fan();

            FanHighCommand fanHighCommand = new FanHighCommand(fan);
            FanMeduimCommand fanMeduimCommand = new FanMeduimCommand(fan);
            FanLowCommand fanLowCommand = new FanLowCommand(fan);
            FanOffCommand fanOffCommand = new FanOffCommand(fan);

            // Remote from Example 2 Reused
            remote3.SetCommand(0, fanHighCommand, fanOffCommand);
            remote3.SetCommand(1, fanMeduimCommand, fanOffCommand);

            remote3.OnButtonWasPressed(0);              // High
            remote3.OffButtonWasPressed(0);             // Off
            remote3.UndoButtonWasPressed();             // Back To High
        }
    }
}

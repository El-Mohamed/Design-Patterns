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

        }
    }
}

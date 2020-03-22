namespace Command_Pattern
{
    public class Fan
    {
        public static int HIGH = 3;
        public static int MEDUIM = 2;
        public static int LOW = 1;
        public static int OFF = 0;

        int speed;

        public Fan()
        {
            speed = OFF;
        }

        public void High()
        {
            speed = HIGH;
            System.Console.WriteLine("Speed is HIGH now");
        }

        public void Meduim()
        {
            speed = MEDUIM;
            System.Console.WriteLine("Speed is MEDIUM now");
        }

        public void Low()
        {
            speed = HIGH;
            System.Console.WriteLine("Speed is LOW now");
        }

        public void Off()
        {
            speed = OFF;
            System.Console.WriteLine("No Speed now");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
namespace Singleton_Pattern
{
    public sealed class People
    {
        // Singleton don't have parameters, everything is private

        private int age;

        private static volatile People instance;
        private static object syncRoot = new object();

        private People()
        {
            age = 0;
        }

        public static People GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new People();
                        }
                    }
                }

                return instance;
            }
        }

        // People stuff

        public void MakeOlder()
        {
            System.Console.WriteLine("Making Older...");
            age++;
        }

        public void ShowAge()
        {
            System.Console.WriteLine("Current Age: " + age);
        }

    }
}
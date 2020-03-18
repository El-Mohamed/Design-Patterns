namespace Signleton_Pattern
{

    // Rename it to own class

    public sealed class Singleton2  // Threadsafe, the first version was not
    {

        //The volatile keyword ensures that multiple threads handle the uniqueInstance 
        //variable correctly when it is being initialized to the Singleton instance.

        private static volatile Singleton2 instance;
        private static object syncRoot = new object();

        private Singleton2()
        {

        }

        public static Singleton2 GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton2();
                        }
                    }
                }

                return instance;
            }
        }

    }
}
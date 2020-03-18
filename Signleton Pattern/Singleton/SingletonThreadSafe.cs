namespace Signleton_Pattern
{

    // Rename it to own class
    public sealed class Singleton
    {

        private static volatile Singleton instance;
        private static object syncRoot = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }

    }
}
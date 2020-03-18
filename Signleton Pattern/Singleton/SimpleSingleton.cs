namespace Signleton_Pattern
{
    public class SimpleSingleton
    {
        private static SimpleSingleton uniqueInstance = new SimpleSingleton();

        private SimpleSingleton() { }

        public static SimpleSingleton GetInstance()
        {
            return uniqueInstance;
        }
    }
}
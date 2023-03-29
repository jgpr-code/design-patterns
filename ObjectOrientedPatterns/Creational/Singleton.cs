namespace ObjectOrientedPatterns.Creational.Singleton
{
    // see https://en.wikipedia.org/wiki/Singleton_pattern

    public class ConfigSingleton
    {
        public static ConfigSingleton GetInstance
        {
            get
            {
                instance ??= new ConfigSingleton();
                return instance;
            }
        }
        public int GetValue() => myValue;
        private ConfigSingleton()
        {
            Console.WriteLine("Initialize Singleton: Please config a value (int):");
            string? line = Console.ReadLine();
            if (line != null)
            {
                try
                {
                    myValue = int.Parse(line);
                } catch
                {
                    Console.WriteLine("No parse to int, using 0 as default");
                    myValue = 0;
                }
            }
        }
        private static ConfigSingleton? instance = null;
        private readonly int myValue;
    }
}

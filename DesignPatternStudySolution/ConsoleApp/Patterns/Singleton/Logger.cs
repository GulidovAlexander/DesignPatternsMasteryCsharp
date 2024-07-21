namespace ConsoleApp.Patterns.Singleton
{
    public sealed class Logger
    {
        private static Logger instance;
        private static readonly object padlock = new object();

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (padlock)
                    {
                        if(instance == null)
                        {
                            instance = new Logger();
                        }
                    }
                }
                return instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(String.Format("{0}: {1}", DateTime.Now, message));
        }
    }
}

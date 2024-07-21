namespace ConsoleApp.Patterns.Singleton
{
    // Создайте класс DatabaseConnection, который будет реализовывать паттерн Singleton.
    // Этот класс должен предоставлять метод Connect для установки соединения с
    // базой данных и метод Disconnect для закрытия соединения.
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private static readonly object padlock = new object();

        private DatabaseConnection()
        {
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (padlock) 
                    {
                        if (instance == null)
                        {
                            instance = new DatabaseConnection();
                        }
                    }
                }
                return instance;
            }
        }

        public void Connect()
        {
            Console.WriteLine("Connect to the database...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnect from the database...");
        }
    }
}

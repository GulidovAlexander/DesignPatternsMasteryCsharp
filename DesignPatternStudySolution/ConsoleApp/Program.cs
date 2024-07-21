
using ConsoleApp.Patterns.Singleton;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingSingletonPatterns();

            Console.ReadKey();
        }

        private static void CheckingSingletonPatterns()
        {
            #region DatabaseConnection
            var databaseConnection = DatabaseConnection.Instance;
            databaseConnection.Connect();
            databaseConnection.Disconnect();
            #endregion

            #region Logger
            var logger = Logger.Instance;
            logger.Log("Error message example");
            #endregion
        }
    }
}

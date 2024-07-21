
using ConsoleApp.Interfaces;
using ConsoleApp.Patterns.FactoryMethod;
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

            #region Cars
            var bikeFactory = new BikeFactory();
            var carFactory = new CarFactory();
            var truckFactory = new TruckFactory();

            var vehicles = new List<IVehicle>()
            {
                bikeFactory.CreateVehicle(),
                carFactory.CreateVehicle(),
                truckFactory.CreateVehicle()
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
            }
            #endregion
        }
    }
}

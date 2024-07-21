using ConsoleApp.Interfaces;

namespace ConsoleApp.Patterns.FactoryMethod.Cars
{
    internal class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Bike");
        }
    }
}

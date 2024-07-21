using ConsoleApp.Interfaces;

namespace ConsoleApp.Patterns.FactoryMethod.Cars
{
    internal class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Truck");
        }
    }
}

using ConsoleApp.Interfaces;

namespace ConsoleApp.Patterns.FactoryMethod.Cars
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car");
        }
    }
}

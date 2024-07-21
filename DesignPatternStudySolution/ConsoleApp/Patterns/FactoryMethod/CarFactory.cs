using ConsoleApp.Interfaces;
using ConsoleApp.Patterns.FactoryMethod.Cars;

namespace ConsoleApp.Patterns.FactoryMethod
{
    internal class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}

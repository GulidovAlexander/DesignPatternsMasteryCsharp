using ConsoleApp.Interfaces;
using ConsoleApp.Patterns.FactoryMethod.Cars;

namespace ConsoleApp.Patterns.FactoryMethod
{
    internal class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}

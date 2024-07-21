using ConsoleApp.Interfaces;

namespace ConsoleApp.Patterns.FactoryMethod
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
}

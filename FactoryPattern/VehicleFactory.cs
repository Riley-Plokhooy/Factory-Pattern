namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle CreateVehicle(int wheelCount)
    {
        switch (wheelCount)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            case 18:
                return new BigRig();
            default:
                return new Car();
        }
    }
}
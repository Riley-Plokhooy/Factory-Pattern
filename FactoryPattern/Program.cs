namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            var wheelCount = int.Parse(Console.ReadLine());
            
            var vehicle = VehicleFactory.CreateVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What type of vehicle would you like to make today?");
            Console.WriteLine("Car or Motorcycle?");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicles myVehicle = factory.CreateVehicle(userInput);

            myVehicle.Drive();

            Console.WriteLine("Lets make another vehicle");
            userInput = Console.ReadLine();

        }
    }
}

using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            string[] truckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string action = commands[0];
                string typeOfVehichle = commands[1];
                double value = double.Parse(commands[2]);

                if (typeOfVehichle == "Car")
                {
                    CompleteCommand(car, action, value);
                }
                else if (typeOfVehichle == "Truck")
                {
                    CompleteCommand(truck, action, value);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void CompleteCommand(Vehicle vehicle, string action, double value)
        {
            if (action == "Drive")
            {
                Console.WriteLine(vehicle.Drive(value));
            }
            else if (action == "Refuel")
            {
                vehicle.Refuel(value);
            }
        }
    }
}

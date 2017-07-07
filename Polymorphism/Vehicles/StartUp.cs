using System;

public class StartUp
{
    public static void Main()
    {
        var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var busInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var commandsCount = int.Parse(Console.ReadLine());

        try
        {
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]), 0.9);
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]), 1.6);
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]), 1.4);

            for (int i = 0; i < commandsCount; i++)
            {
                try
                {
                    var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (command[0].ToLower() == "drive")
                    {
                        if (command[1].ToLower() == "car")
                        {
                            car.Drive(double.Parse(command[2]));
                        }
                        else if (command[1].ToLower() == "truck")
                        {
                            truck.Drive(double.Parse(command[2]));
                        }
                        else
                        {
                            bus.Drive(double.Parse(command[2]));
                        }
                    }
                    else if (command[0].ToLower() == "refuel")
                    {
                        if (command[1].ToLower() == "car")
                        {
                            car.Refuel(double.Parse(command[2]));
                        }
                        else if (command[1].ToLower() == "truck")
                        {
                            truck.Refuel(double.Parse(command[2]));
                        }
                        else
                        {
                            bus.Refuel(double.Parse(command[2]));
                        }

                    }
                    else if (command[0].ToLower() == "driveempty")
                    {
                        bus.DriveEmpty(double.Parse(command[2]));
                    }
                }
                catch (Exception ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }


            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

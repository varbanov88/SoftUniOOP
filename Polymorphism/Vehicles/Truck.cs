
using System;

public class Truck : Vehicle
{
    public Truck(double fuel, double consuption, double tankCapacity, double airConditionConsumption)
        : base(fuel, consuption, tankCapacity, airConditionConsumption)
    {
    }

    public override void Drive(double distance)
    {
        var neededFuel = (base.ConsumptionPerKm + base.AirConditionConsumption) * distance;
        if (base.FuelQuantity >= neededFuel)
        {
            Console.WriteLine($"{typeof(Truck)} travelled {distance} km");
            base.FuelQuantity -= neededFuel;
        }

        else
        {
            Console.WriteLine($"{typeof(Truck)} needs refueling");
        }

    }

    public override void Refuel(double quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        base.FuelQuantity += quantity * 0.95;
    }
}


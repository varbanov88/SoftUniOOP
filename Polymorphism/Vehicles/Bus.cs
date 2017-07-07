
using System;

public class Bus : Vehicle
{
    public Bus(double fuel, double consuption, double tankCapacity, double airConditionCons)
        : base(fuel, consuption, tankCapacity, airConditionCons)
    {
    }

    public override void Drive(double distance)
    {
        var neededFuel = (base.ConsumptionPerKm + base.AirConditionConsumption) * distance;
        if (base.FuelQuantity >= neededFuel)
        {
            Console.WriteLine($"{typeof(Bus)} travelled {distance} km");
            base.FuelQuantity -= neededFuel;
        }

        else
        {
            Console.WriteLine($"{typeof(Bus)} needs refueling");
        }
    }

    public override void DriveEmpty(double distance)
    {
        var neededFuel = base.ConsumptionPerKm * distance;
        if (base.FuelQuantity >= neededFuel)
        {
            Console.WriteLine($"{typeof(Bus)} travelled {distance} km");
            base.FuelQuantity -= neededFuel;
        }

        else
        {
            Console.WriteLine($"{typeof(Bus)} needs refueling");
        }

    }

    public override void Refuel(double quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        if (base.FuelQuantity + quantity > base.TankCapacity)
        {
            throw new ArgumentException("Cannot fit fuel in tank");
        }
        base.FuelQuantity += quantity;
    }
}


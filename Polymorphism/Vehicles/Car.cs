
using System;

public class Car : Vehicle
{
    public Car(double fuel, double consuption, double tankCapacity, double airConditionConsumption) 
        : base(fuel, consuption, tankCapacity, airConditionConsumption)
    {
    }

    public override void Drive(double distance)
    {
        var neededFuel = (base.ConsumptionPerKm + base.AirConditionConsumption) * distance;
        if (base.FuelQuantity >= neededFuel)
        {
            Console.WriteLine($"{typeof(Car)} travelled {distance} km");
            base.FuelQuantity -= neededFuel;
        }

        else
        {
            Console.WriteLine($"{typeof(Car)} needs refueling");
        }
    }

    public override void Refuel(double quantity)
    {
        if (quantity <= 0 ) 
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



using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double consumptionPerKm;
    private double airConditionConsumption;
    private double tankCapacity;

    public Vehicle(double fuel, double consuption, double tankCapacity, double airConditionCons)
    {
        this.FuelQuantity = fuel;
        this.ConsumptionPerKm = consuption;
        this.AirConditionConsumption = airConditionCons;
        this.TankCapacity = tankCapacity;
    }

    protected double TankCapacity
    {
        get => this.tankCapacity;
        set { this.tankCapacity = value; }
    }

    protected double AirConditionConsumption
    {
        get => this.airConditionConsumption;
        set { this.airConditionConsumption = value; }
    }

    public double FuelQuantity
    {
        get => this.fuelQuantity;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.fuelQuantity = value;
        }
    }

    public double ConsumptionPerKm
    {
        get => this.consumptionPerKm;
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Consumption must be positive");
            }
            this.consumptionPerKm = value;
        }
    }

    public abstract void Drive(double distance);
    public abstract void Refuel(double quantity);
    public virtual void DriveEmpty(double distance) { }
}


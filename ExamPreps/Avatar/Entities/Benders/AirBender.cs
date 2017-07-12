using System;

public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power, double aerialIntegrity) 
        : base(name, power)
    {
        this.aerialIntegrity = aerialIntegrity;
    }

    public override double GetBenderTotalPower()
    {
        return this.Power * this.aerialIntegrity;
    }

    public override string ToString()
    {
        return $"Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.aerialIntegrity:f2}";
    }
}


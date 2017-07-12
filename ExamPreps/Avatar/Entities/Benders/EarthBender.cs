﻿using System;

public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, int power, double groundSaturation )
        : base(name, power)
    {
        this.groundSaturation = groundSaturation;
    }

    public override double GetBenderTotalPower()
    {
        return this.Power * this.groundSaturation;
    }

    public override string ToString()
    {
        return $"Earth Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.groundSaturation:f2}";
    }
}


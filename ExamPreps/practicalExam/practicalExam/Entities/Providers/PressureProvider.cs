﻿public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) 
        : base(id, energyOutput)
    {
    }

    public override double EnergyOutput
    {
        get => base.EnergyOutput;
        protected set => base.EnergyOutput = value + value / 2;
    }
}


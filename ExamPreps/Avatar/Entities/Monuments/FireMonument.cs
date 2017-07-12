﻿using System;

public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name, int fireAffinity) 
        : base(name)
    {
        this.fireAffinity = fireAffinity;
    }

    public override int GetMonumentPoints()
    {
        return this.fireAffinity;
    }

    public override string ToString()
    {
        return $"Fire Monument: {this.Name}, Fire Affinity: {this.fireAffinity}";
    }

}


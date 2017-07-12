﻿using System.Collections.Generic;

public class Garage
{
    private Dictionary<int, Car> parkedCars;

    public Garage()
    {
        this.parkedCars = new Dictionary<int, Car>();
    }

    public Dictionary<int, Car> ParkedCars => this.parkedCars;
}


﻿using System;

public class StartUp
{
    public static void Main()
    {
        var driverName = Console.ReadLine();
        ICar ferrari = new Ferrari(driverName);

        Console.WriteLine(ferrari);

        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }
    }
}


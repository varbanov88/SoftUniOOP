﻿public class Car
{
    private string model;
    private Engine engine;
    private int weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = 0;
        this.Color = "n/a";
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    public Engine Engine
    {
        get
        {
            return this.engine;
        }
        set
        {
            this.engine = value;
        }
    }

    public string Color
    {
        get
        {
            return this.color;
        }
        set
        {
            this.color = value;
        }
    }

    public int Weight
    {
        get
        {
            return this.weight;
        }
        set
        {
            this.weight = value;
        }
    }
}


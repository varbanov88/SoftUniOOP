using System.Collections.Generic;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private List<Tire> tires;

    public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
    {
        this.tires = new List<Tire>(tires);
        Engine = engine;
        Cargo = cargo;
        Model = model;
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
            this.engine = new Engine
            {
                Power = value.Power,
                Speed = value.Speed
            };
        }
    }

    public Cargo Cargo
    {
        get
        {
            return this.cargo;
        }
        set
        {
            this.cargo = new Cargo
            {
                Type = value.Type,
                Weight = value.Weight
            };
        }
    }

    public List<Tire> Tires
    {
        get
        {
            return this.tires;
        }
    }

  
}


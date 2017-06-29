public class Engine
{
    private string model;
    private int power;
    private int displacement;
    private string efficienty;

    public Engine(string model, int power)
    {
        Model = model;
        Power = power;
        Displacement = 0;
        Efficienty = "n/a";
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

    public int Power
    {
        get
        {
            return this.power;
        }
        set
        {
            this.power = value;
        }
    }

    public int Displacement
    {
        get
        {
            return this.displacement;
        }
        set
        {
            this.displacement = value;
        }
    }

    public string Efficienty
    {
        get
        {
            return this.efficienty;
        }
        set
        {
            this.efficienty = value;
        }
    }
}


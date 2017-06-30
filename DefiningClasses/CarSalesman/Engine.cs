public class Engine
{
    private string model;
    private int power;
    private int displacement;
    private string efficienty;

    public Engine(string model, int power)
    {
        this.Model = model;
        this.Power = power;
        this.Displacement = 0;
        this.Efficienty = "n/a";
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


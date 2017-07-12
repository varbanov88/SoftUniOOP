public abstract class Bender
{
    private string name;
    private int power;

    public Bender(string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    protected string Name => this.name;

    protected int Power => this.power;

    public abstract double GetBenderTotalPower();
}


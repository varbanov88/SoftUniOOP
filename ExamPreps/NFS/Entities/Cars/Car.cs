
using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    protected int horsepower;
    protected int acceleration;
    protected int suspension;
    protected int durability;

    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }


    public int Horsepower => this.horsepower;

    public int Acceleration => this.acceleration;

    public int Suspension => this.suspension;

    public int Durability => this.durability;

    public string Brand => this.brand;

    public string Model => this.model;


    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}")
            .AppendLine($"{horsepower} HP, 100 m/h in {acceleration} s")
            .AppendLine($"{suspension} Suspension force, {durability} Durability");

        return sb.ToString().Trim();
    }

    public virtual void Tune(int index, string addOn)
    {
        this.horsepower += index;
        this.suspension += index / 2;
    }
}


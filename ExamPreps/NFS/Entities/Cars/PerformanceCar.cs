
using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.addOns = new List<string>();
        this.horsepower += this.horsepower * 50 / 100;
        this.suspension -= this.suspension * 25 / 100;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        if (this.addOns.Count == 0)
        {
            sb.AppendLine("Add-ons: None");
        }

        else
        {
            sb.AppendLine($"Add-ons: {string.Join(", ", this.addOns)}");
        }

        return sb.ToString().Trim();
    }

    public override void Tune(int index, string addOn)
    {
        base.Tune(index, addOn);
        this.addOns.Add(addOn);
    }
}


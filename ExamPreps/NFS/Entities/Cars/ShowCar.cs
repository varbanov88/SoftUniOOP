using System.Text;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"{this.stars} *");

        return sb.ToString().Trim();
    }

    public override void Tune(int index, string addOn)
    {
        base.Tune(index, addOn);
        this.stars += index;
    }
}

public class Ferrari : ICar
{
    private const string model = "488-Spider";

    public Ferrari(string driverName)
    {
        this.DriverName = driverName;
    }

    public string DriverName { get; private set; }

    public string Model => model;

    public string PushTheGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public string UseTheBrakes()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        return $"{model}/{UseTheBrakes()}/{PushTheGasPedal()}/{this.DriverName}";
    }
}


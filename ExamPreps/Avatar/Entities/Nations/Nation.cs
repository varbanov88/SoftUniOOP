using System.Collections.Generic;
using System.Text;

public abstract class Nation
{
    private string name;
    private List<Bender> benders;
    private List<Monument> monuments;
    private double totalPowerPoints;

    public Nation(string name)
    {
        this.name = name;
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public string Name => this.name;

    public double TotalPowerPoints => this.totalPowerPoints;

    public List<Bender> Benders => this.benders;

    public List<Monument> Monuments => this.monuments;

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.name} Nation");

        if (this.Benders.Count == 0)
        {
            sb.AppendLine("Benders: None");
        }
        else
        {
            sb.AppendLine("Benders:");

            foreach (var bender in this.Benders)
            {
                sb.AppendLine($"###{bender.ToString()}");
            }
        }

        if (this.Monuments.Count == 0)
        {
            sb.AppendLine("Monuments: None");
        }
        else
        {
            sb.AppendLine("Monuments:");

            foreach (var monument in this.Monuments)
            {
                sb.AppendLine($"###{monument.ToString()}");
            }
        }

        return sb.ToString().Trim();
    }

    public void GetTotalPowerPoints()
    {
        double benderPoints = 0;        
        foreach (var ben in this.benders)
        {
            benderPoints += ben.GetBenderTotalPower();
        }

        int monumentsPoints = 0;
        foreach (var mon in this.monuments)
        {
            monumentsPoints += mon.GetMonumentPoints();
        }

        var increase = (benderPoints / 100) * monumentsPoints;

        this.totalPowerPoints = benderPoints + increase;
    }
}


using System.Linq;
using System.Collections.Generic;
using System.Text;

public class NationsBuilder
{
    private List<Nation> nations;
    private Queue<string> wars;

    public NationsBuilder()
    {
        this.nations = new List<Nation>();
        this.wars = new Queue<string>();
        this.nations = AddNations();
    }

    private List<Nation> AddNations()
    {
        var currNations = new List<Nation>();
        Nation air = new AirNation();
        Nation water = new WaterNation();
        Nation fire = new FireNation();
        Nation earth = new EarthNation();

        currNations.Add(air);
        currNations.Add(water);
        currNations.Add(fire);
        currNations.Add(earth);

        return currNations;
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[1];
        Bender bender = BenderFactory.CreateBender(benderArgs);
        this.nations.Where(n => n.Name == type).FirstOrDefault().Benders.Add(bender);
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[1];
        Monument monument = ManumentFactory.CreateMonument(monumentArgs);
        this.nations.Where(n => n.Name == type).FirstOrDefault().Monuments.Add(monument);
    }

    public string GetStatus(string nationsType)
    {
        var nation = this.nations.Where(n => n.Name == nationsType).FirstOrDefault();
        return nation.ToString();
    }

    public void IssueWar(string nationsType)
    {
        this.wars.Enqueue(nationsType);

        foreach (var nat in nations)
        {
            nat.GetTotalPowerPoints();
        }

        var winner = this.nations.OrderByDescending(n => n.TotalPowerPoints).First();
        foreach (var nation in this.nations.Where(n => n.Name != winner.Name))
        {
            nation.Benders.Clear();
            nation.Monuments.Clear();
        }
    }

    public string GetWarsRecord()
    {
        var counter = 1;
        var sb = new StringBuilder();

        while (this.wars.Count > 0)
        {
            var attacker = wars.Dequeue();
            sb.AppendLine($"War {counter} issued by {attacker}");
            counter++;
        }
        return sb.ToString().Trim();
    }

}

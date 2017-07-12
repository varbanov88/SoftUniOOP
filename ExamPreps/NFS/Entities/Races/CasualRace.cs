using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {
    }

    public override string ToString()
    {
        var winners = GetWinners(this.Participants, this.PrizePool);
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}");
        sb.AppendLine(winners);

        return sb.ToString().Trim();
    }

    private string GetWinners(Dictionary<int, Car> participants, int prizePool)
    {
        var result = participants.Values
            .OrderByDescending(c => (c.Horsepower / c.Acceleration) + (c.Suspension + c.Durability))
            .Take(3)
            .ToList();

        var sb = new StringBuilder();
        var prizesPortions = new List<int> { 50, 30, 20 };
        var counter = 0;

        foreach (var car in result)
        {
            var pp = (car.Horsepower / car.Acceleration) + (car.Suspension + car.Durability);
            sb.AppendLine($"{counter + 1}. {car.Brand} {car.Model} {pp}PP - ${prizePool * prizesPortions[counter] / 100}");
            counter++;
        }
        return sb.ToString();
    }
}

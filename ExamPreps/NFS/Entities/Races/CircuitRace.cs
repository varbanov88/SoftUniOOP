using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CircuitRace : Race
{
    private int laps;

    public CircuitRace(int length, string route, int prizePool, int laps)
        : base(length, route, prizePool)
    {
        this.laps = laps;
    }

    public override string ToString()
    {
        var winners = GetWinners(this.Participants, this.PrizePool);
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length * this.laps}");
        sb.AppendLine(winners);

        return sb.ToString().Trim();
    }

    private string GetWinners(Dictionary<int, Car> participants, int prizePool)
    {
        for (int i = 0; i < this.laps; i++)
        {
            foreach (var car in participants.Values)
            {
                car.Durability -= this.Length * this.Length;
            }
        }

        var result = participants.Values
            .OrderByDescending(c => (c.Horsepower / c.Acceleration) + (c.Suspension + c.Durability))
            .Take(4)
            .ToList();

        var sb = new StringBuilder();
        var prizesPortions = new List<int> { 40, 30, 20, 10 };
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


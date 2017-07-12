using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TimeLimitRace : Race
{
    private int goldTime;

    public TimeLimitRace(int length, string route, int prizePool, int goldTime) 
        : base(length, route, prizePool)
    {
        this.goldTime = goldTime;
    }

    public override void AddPaticipant(int id, Car car)
    {
        if (this.Participants.Count == 0)
        {
            this.Participants.Add(id, car);
        }
    }

    public override string ToString()
    {
        var winners = GetMedalAndPrice(this.Participants, this.PrizePool);
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}");
        sb.Append(winners);

        return sb.ToString();
    }

    private string GetMedalAndPrice(Dictionary<int, Car> participants, int price)
    {
        var car = participants.First().Value;
        var timePerformance = this.Length * ((car.Horsepower / 100) * car.Acceleration);

        var medal = GetMedal(timePerformance);
        switch (medal)
        {
            case "Silver":
                price = price * 50 / 100;
                break;

            case "Bronze ":
                price = price * 30 / 100;
                break;
        }
        
        var sb = new StringBuilder();
        sb.AppendLine(String.Format($"{car.Brand} {car.Model} - {timePerformance} s."));
        sb.AppendLine(String.Format($"{medal} Time, ${price}."));

        return sb.ToString();
    }

    private string GetMedal(int time)
    {
        if (time <= this.goldTime)
        {
            return "Gold";
        }

        else if (time <= this.goldTime + 15)
        {
            return "Silver";
        }

        else
        {
            return "Bronze";
        }
    }
}


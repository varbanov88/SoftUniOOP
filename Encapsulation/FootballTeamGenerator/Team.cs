using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    public Team(string name)
    {
        this.Name = name;
        this.players = new List<Player>();
    }

    private string name;
    private int rating;
    private List<Player> players;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            this.name = value;
        }
    }

    public void AddPlayer(string team, Player player)
    {
        if (this.Name != team)
        {
            throw new ArgumentException($"Team {team} does not exist.");
        }

        this.players.Add(player);
    }

    public void RemovePlayer(string team, string playerName)
    {
        var currPlayer = this.players.FirstOrDefault(p => p.Name == playerName);
        if (currPlayer == null)
        {
            throw new ArgumentException($"Player {playerName} is not in {team} team. ");
        }

        this.players.Remove(currPlayer);
    }

    public void ShowTeamRating(string team)
    {
        if (this.Name != team)
        {
            throw new ArgumentException($"Team {team} does not exist.");
        }

        if (this.players.Count == 0)
        {
            Console.WriteLine($"{this.Name} - 0");
            return;
        }

        var skill = Math.Ceiling(this.players.Average(p => p.OverallSkill));
        Console.WriteLine($"{this.Name} - {skill}");
    }
}


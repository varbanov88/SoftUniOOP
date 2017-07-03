using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    public Player(string name, int endurance, int sprint, int drible, int passing, int shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Drible = drible;
        this.Passing = passing;
        this.Shooting = shooting;
        this.overallSkill = CalculateOverallSkill();
    }

    private const int MinValue = 0;
    private const int MaxValue = 100;

    private string name;
    private int endurance;
    private int sprint;
    private int drible;
    private int passing;
    private int shooting;
    private double overallSkill;

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

    public int Endurance
    {
        get
        {
            return this.endurance;
        }
        set
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentException($"{nameof(Endurance)} should be between 0 and 100. ");
            }
            this.endurance = value;
        }
    }

    public int Sprint
    {
        get
        {
            return this.sprint;
        }
        set
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentException($"{nameof(Sprint)} should be between 0 and 100. ");
            }
            this.sprint = value;
        }
    }

    public int Drible
    {
        get
        {
            return this.drible;
        }
        set
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentException($"{nameof(Drible)} should be between 0 and 100. ");
            }
            this.drible = value;
        }
    }

    public int Passing
    {
        get
        {
            return this.passing;
        }
        set
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentException($"{nameof(Passing)} should be between 0 and 100. ");
            }
            this.passing = value;
        }
    }

    public int Shooting
    {
        get
        {
            return this.shooting;
        }
        set
        {
            if (value < MinValue || value > MaxValue)
            {
                throw new ArgumentException($"{nameof(Shooting)} should be between 0 and 100. ");
            }
            this.shooting = value;
        }
    }

    public double OverallSkill => this.overallSkill;

    private double CalculateOverallSkill()
    {
        var skills = new List<int> { this.Passing, this.Shooting, this.Sprint, this.Endurance, this.Drible };

        return skills.Average();
    }
}



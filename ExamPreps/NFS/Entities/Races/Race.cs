using System.Collections.Generic;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private Dictionary<int, Car> participants;

    public Race(int length, string route, int prizePool)
    {
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = new Dictionary<int, Car>();
    }

    public int Length => this.length;

    public string Route => this.route;

    public int PrizePool => this.prizePool;

    public Dictionary<int, Car> Participants => this.participants;

    public virtual void AddPaticipant(int id, Car car)
    {
        this.participants.Add(id, car);
    }
}


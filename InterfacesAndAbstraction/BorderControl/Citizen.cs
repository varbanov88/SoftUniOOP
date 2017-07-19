using System;

public class Citizen : ICreature
{
    public Citizen(string id)
    {
        this.Id = id;
    }

    public string Id { get; private set; }
}


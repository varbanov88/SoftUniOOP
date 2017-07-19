using System;

public class Robot : ICreature
{
    public Robot(string id)
    {
        this.Id = id;
    }

    public string Id { get; private set; }
}


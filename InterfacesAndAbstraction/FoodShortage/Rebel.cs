﻿public class Rebel : IBuyer
{
    public Rebel(string name, string age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }

    public string Name { get; private set; }

    //prop Age will be changed to int if needed
    public string Age { get; private set; }

    public string Group { get; private set; }

    public int Food { get; private set; }

    public void BuyFood()
    {
        this.Food += 5;
    }
}


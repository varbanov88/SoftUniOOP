using System;
using System.Collections.Generic;
using System.Linq;


public class Family
{
    public List<Person> members;

    public Family()
    {
        this.members = new List<Person>();
    }

    public void AddMember(Person member)
    {
        members.Add(member);
    }

    public void GetOldestMember()
    {
        var result = members.OrderByDescending(p => p.age).First();
        Console.WriteLine($"{result.name} {result.age}");
    }
}


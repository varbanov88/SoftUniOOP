using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        var peopleCount = int.Parse(Console.ReadLine());

        var people = new List<Person>();

        for (int i = 0; i < peopleCount; i++)
        {
            var personInfo = Console.ReadLine().Split();

            var name = personInfo[0];
            var age = int.Parse(personInfo[1]);

            var person = new Person(name, age);

            people.Add(person);
        }

        var result = people.Where(p => p.Age > 30)
                           .OrderBy(p => p.Name)
                           .ToList();

        foreach (var person in result)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}


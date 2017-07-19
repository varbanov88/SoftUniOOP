using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string input;
        var rebelions = new List<ICreature>();

        while ((input = Console.ReadLine()) != "End")
        {
            var args = input.Split().ToList();
            if (args.Count == 3)
            {
                var citizen = new Citizen(args.Last());
                rebelions.Add(citizen);
            }

            else
            {
                var robot = new Robot(args.Last());
                rebelions.Add(robot);
            }
        }

        var filter = Console.ReadLine();

        rebelions.Where(r => r.Id.EndsWith(filter))
            .ToList()
            .ForEach(r => Console.WriteLine(r.Id));
    }
}


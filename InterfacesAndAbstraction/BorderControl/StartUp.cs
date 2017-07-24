using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string input;
        var rebelions = new List<ICreature>();
        var birthDates = new List<IBirthable>();

        while ((input = Console.ReadLine()) != "End")
        {
            var args = input.Split().ToList();
            if (args[0] == "Citizen")
            {
                args.RemoveAt(0);
                var citizen = new Citizen(args[0], args[1], args[2], args[3]);
                rebelions.Add(citizen);
                birthDates.Add(citizen);
            }

            else
            {
                if (args[0] == "Robot")
                {
                    var robot = new Robot(args.Last());
                    rebelions.Add(robot);
                }

                else
                {
                    var pet = new Pet(args[1], args[2]);
                    birthDates.Add(pet);
                }
            }
        }

        //var filter = Console.ReadLine();

        //rebelions.Where(r => r.Id.EndsWith(filter))
        //    .ToList()
        //    .ForEach(r => Console.WriteLine(r.Id));
        var bdate = Console.ReadLine();
        birthDates.Where(b => b.Birthdate.EndsWith(bdate))
                  .ToList()
                  .ForEach(r => Console.WriteLine(r.Birthdate));
    }
}


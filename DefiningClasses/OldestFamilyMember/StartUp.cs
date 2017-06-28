using System;
using System.Reflection;


public class StartUp
{
    public static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        var peopleCount = int.Parse(Console.ReadLine());
        var people = new Family();

        for (int i = 0; i < peopleCount; i++)
        {
            var person = Console.ReadLine().Split();
            var name = person[0];
            var age = int.Parse(person[1]);

            var member = new Person
            {
                age = age,
                name = name
            };

            people.AddMember(member);
        }

        people.GetOldestMember();
    }
}


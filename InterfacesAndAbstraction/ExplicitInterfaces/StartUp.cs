using System;

public class StartUp
{
    public static void Main()
    {
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var args = input.Split();
            var person = new Citizen(args[0]);
            Console.WriteLine(((IPerson)person).GetName());
            Console.WriteLine(((IResident)person).GetName());
        }
    }
}


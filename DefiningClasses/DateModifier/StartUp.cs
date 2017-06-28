using System;


public class StartUp
{
    public static void Main()
    {
        var firstDate = Console.ReadLine();
        var secondtDate = Console.ReadLine();

        var dateSet = new DateModifier
        {
            FirstDate = firstDate,
            SecondDate = secondtDate
        };

        Console.WriteLine(dateSet.CalculateDifference());
    }
}


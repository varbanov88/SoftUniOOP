using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().ToList();
        var urls = Console.ReadLine().Split().ToList();

        var phone = new SmartPhone(numbers, urls);
        Console.WriteLine(phone.Call());
        Console.WriteLine(phone.Browse());
    }
}


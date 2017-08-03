using System;

namespace CardSuit
{
    public class StartUp
    {
        public static void Main()
        {
            CardSuit();
        }

        public static void CardSuit()
        {
            var input = Console.ReadLine();
            Console.WriteLine(input + ":");

            foreach (var value in Enum.GetValues(typeof(Suit)))
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}
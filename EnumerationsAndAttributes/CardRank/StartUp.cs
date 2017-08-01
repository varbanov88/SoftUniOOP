using System;

namespace CardRank
{
    public class StartUp
    {
        public static void Main()
        {
            CardRank(Console.ReadLine());
        }

        public static void CardRank(string command)
        {
            Console.WriteLine($"{command}:");

            var cardRanks = Enum.GetValues(typeof(Rank));

            foreach (var rank in cardRanks)
            {
                Console.WriteLine($"Ordinal value: {(int)rank}; Name value: {rank}");
            }
        }
    }
}

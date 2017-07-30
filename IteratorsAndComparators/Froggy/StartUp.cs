using System;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            var inputStones = Console.ReadLine()
                                     .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

            var lake = new Lake(inputStones);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}

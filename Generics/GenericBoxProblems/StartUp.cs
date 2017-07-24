using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxProblems
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            IList<Box<double>> listOfBoxes = new List<Box<double>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                listOfBoxes.Add(box);
            }

            var element = double.Parse(Console.ReadLine());

            Console.WriteLine(GetGreaterElementCount(listOfBoxes, element));
        }

        public static int GetGreaterElementCount<T>(IList<Box<T>> list, T element)
            where T : IComparable        
            => list.Count(b => b.Item.CompareTo(element) > 0);
    }
}

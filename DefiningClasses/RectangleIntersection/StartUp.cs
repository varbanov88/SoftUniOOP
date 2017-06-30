using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int[] param = Console.ReadLine()
                                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                                  .ToArray();
        int recNum = param[0];
        int intersecCheck = param[1];

        Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

        for (int i = 0; i < recNum; i++)
        {
            string[] dateStrings = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
            Rectangle rectangle = new Rectangle(dateStrings[0], double.Parse(dateStrings[1]), double.Parse(dateStrings[2]), new double[] { double.Parse(dateStrings[3]), double.Parse(dateStrings[4]) });

            rectangles[dateStrings[0]] = rectangle;
        }

        for (int i = 0; i < intersecCheck; i++)
        {
            string[] recIds = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();

            if (rectangles.ContainsKey(recIds[0]) && rectangles.ContainsKey(recIds[1]))
            {
                Console.WriteLine(Rectangle.Intersect(rectangles[recIds[0]], rectangles[recIds[1]]).ToString().ToLower());
            }
        }
    }
}



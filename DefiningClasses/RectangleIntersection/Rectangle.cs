using System;

public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double[] topLeft;

    public Rectangle(string id, double width, double height, double[] topLeft)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.topLeft = new double[] { topLeft[0], topLeft[1] };
    }

    public static bool Intersect(Rectangle r1, Rectangle r2)
    {
        bool intersect = false;

        if (Math.Abs(r1.topLeft[0]) < Math.Abs(r2.topLeft[0] + r2.width))
        {
            if (Math.Abs(r1.topLeft[0] + r1.width) >= Math.Abs(r2.topLeft[0]))
            {
                if (r1.topLeft[1] < Math.Abs((r2.topLeft[1] - r2.height)))
                {
                    if (Math.Abs(r1.topLeft[1] + r1.height) >= Math.Abs(r2.topLeft[1]))
                    {
                        intersect = true;
                    }
                }
            }
        }

        return intersect;
    }
}


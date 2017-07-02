using System;

public class Box
{
    public Box(double length, double width, double height)
    {
        this.length = length;
        this.height = height;
        this.width = width;
    }

    private double length;
    private double width;
    private double height;

    public void SurfaceArea()
    {
        var area = (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
        Console.WriteLine($"Surface Area - {area:f2}");
    }

    public void LateralSurfaceArea()
    {
        var area = 2 * this.length * this.height + 2 * this.width * this.height;
        Console.WriteLine($"Lateral Surface Area - {area:f2}");
    }

    public void Volume()
    {
        var volume = this.length * this.width * this.height;
        Console.WriteLine($"Volume - {volume:f2}");
    }
}


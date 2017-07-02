using System;

public class Box
{
    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Height = height;
        this.Width = width;
    }

    private double length;
    private double width;
    private double height;

    private double Length
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
            }

            this.length = value;
        }
    }

    private double Width
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    private double Height
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            }
            this.height = value;
        }
    }

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


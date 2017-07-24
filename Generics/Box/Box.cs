using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private List<T> data;

    public Box()
    {
        this.data = new List<T>();
    }

    public int Count => this.data.Count;

    public void Add(T element)
    {
        this.data.Insert(0, element);
    }

    public T Remove()
    {
        var element = this.data.First();
        this.data.RemoveAt(0);
        return element;
    }
}


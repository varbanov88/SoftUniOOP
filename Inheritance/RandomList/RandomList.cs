using System;
using System.Collections;
using System.Collections.Generic;

public class RandomList : ArrayList
{
    public RandomList()
    {
        this.rnd = new Random();
        this.data = new List<string>();
    }

    private Random rnd;
    private List<string> data;

    public object RandomString()
    {
        int element = rnd.Next(0, this.data.Count - 1);
        string str = data[element];
        data.Remove(str);
        return str;
    }
}


public class Child
{
    private string name;
    private string birthday;

    public Child(string name, string birthday)
    {
        Name = name;
        Birthday = birthday;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public string Birthday
    {
        get
        {
            return this.birthday;
        }
        set
        {
            this.birthday = value;
        }
    }
}


public class Person
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    private int age;
    private string name;

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            this.age = value;
        }
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
}


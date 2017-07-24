public class Citizen : IBuyer
{
    //Pesho 25 8904041303 04/04/1989
    public Citizen(string name, string age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Name { get; private set; }

    public string Age { get; private set; }

    public string Id { get; private set; }

    public string Birthdate { get; private set; }

    public int Food { get; private set; }

    public void BuyFood()
    {
        this.Food += 10;
    }
}


public class Citizen : ICreature, IBirthable
{
    public Citizen(string name, string age, string id, string birthdate)
    {
        this.Name = name;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Id { get; private set; }

    public string Name { get; private set; }

    public string Birthdate { get; private set; }
}


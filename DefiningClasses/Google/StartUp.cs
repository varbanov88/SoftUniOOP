using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        string input;
        var people = new List<Person>();

        while ((input = Console.ReadLine()) != "End")
        {
            var info = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var personName = info.First();
            var index = people.FindIndex(p => p.Name == personName);
            var property = info[1];

            if (index >= 0)
            {
                UpdateInfoToPerson(people, info, index, property);
            }

            else
            {
                var person = new Person(personName);
                AddPersonInfo(people, info, property, person);
            }
        }

        var name = Console.ReadLine();
        var result = people.Where(p => p.Name == name).FirstOrDefault();

        PrintResult(result);

    }

    private static void PrintResult(Person result)
    {
        Console.WriteLine(result.Name);

        Console.WriteLine("Company:");
        if (result.Company != null)
        {
            Console.WriteLine($"{result.Company.Name} {result.Company.Department} {result.Company.Salary:f2}");
        }

        Console.WriteLine("Car:");
        if (result.Car != null)
        {
            Console.WriteLine($"{result.Car.Model} {result.Car.Speed}");
        }

        Console.WriteLine("Pokemon:");
        if (result.Pokemons.Count > 0)
        {
            foreach (var pok in result.Pokemons)
            {
                Console.WriteLine($"{pok.Name} {pok.Type}");
            }
        }

        Console.WriteLine("Parents:");
        if (result.Parents.Count > 0)
        {
            foreach (var par in result.Parents)
            {
                Console.WriteLine($"{par.Name} {par.Birthday}");
            }
        }

        Console.WriteLine("Children:");
        if (result.Children.Count > 0)
        {
            foreach (var child in result.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }
    }

    private static void AddPersonInfo(List<Person> people, string[] info, string property, Person person)
    {
        switch (property)
        {
            case "company":
                var companyName = info[2];
                var department = info[3];
                var salary = double.Parse(info[4]);
                var company = new Company(companyName, department, salary);

                person.Company = company;
                people.Add(person);
                break;

            case "pokemon":
                var pokemonName = info[2];
                var type = info[3];
                var pokemon = new Pokemon(pokemonName, type);

                person.Pokemons.Add(pokemon);
                people.Add(person);
                break;

            case "parents":
                var parentName = info[2];
                var birthDay = info[3];
                var parent = new Parent(parentName, birthDay);

                person.Parents.Add(parent);
                people.Add(person);
                break;

            case "children":
                var childName = info[2];
                var childBirthDay = info[3];
                var child = new Child(childName, childBirthDay);

                person.Children.Add(child);
                people.Add(person);
                break;

            case "car":
                var model = info[2];
                var speed = info[3];
                var car = new Car(model, speed);

                person.Car = car;
                people.Add(person);
                break;
        }
    }

    private static void UpdateInfoToPerson(List<Person> people, string[] info, int index, string property)
    {
        switch (property)
        {
            case "company":
                var companyName = info[2];
                var department = info[3];
                var salary = double.Parse(info[4]);
                var company = new Company(companyName, department, salary);

                people[index].Company = company;
                break;

            case "pokemon":
                var pokemonName = info[2];
                var type = info[3];
                var pokemon = new Pokemon(pokemonName, type);

                people[index].Pokemons.Add(pokemon);
                break;

            case "parents":
                var parentName = info[2];
                var birthDay = info[3];
                var parent = new Parent(parentName, birthDay);

                people[index].Parents.Add(parent);
                break;

            case "children":
                var childName = info[2];
                var childBirthDay = info[3];
                var child = new Child(childName, childBirthDay);

                people[index].Children.Add(child);
                break;

            case "car":
                var model = info[2];
                var speed = info[3];
                var car = new Car(model, speed);

                people[index].Car = car;
                break;
        }
    }
}


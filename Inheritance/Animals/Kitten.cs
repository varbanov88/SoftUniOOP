using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Kitten : Animal
{
    public Kitten(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string IntroduceAnimal()
    {
        return $"{typeof(Kitten)}" + Environment.NewLine + $"{base.Name} {base.Age} {base.Genger}";
    }

    public override string ProduceSound()
    {
        return "Miau";
    }
}


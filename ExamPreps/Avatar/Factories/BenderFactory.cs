using System.Collections.Generic;

public static class BenderFactory
{
    public static Bender CreateBender(List<string> benderArgs)
    {
        var type = benderArgs[1];
        var name = benderArgs[2];
        int power = int.Parse(benderArgs[3]);
        double secondaryPower = double.Parse(benderArgs[4]);

        Bender bender;
        switch (type)
        {
            case "Air":
                bender = new AirBender(name, power, secondaryPower);
                return bender;

            case "Water":
                bender = new WaterBender(name, power, secondaryPower);
                return bender;

            case "Fire":
                bender = new FireBender(name, power, secondaryPower);
                return bender;

            default:
                bender = new EarthBender(name, power, secondaryPower);
                return bender;
        }
    }
}






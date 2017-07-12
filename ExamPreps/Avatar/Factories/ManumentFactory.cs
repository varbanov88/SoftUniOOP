using System.Collections.Generic;

public static class ManumentFactory
{
    public static Monument CreateMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[1];
        var name = monumentArgs[2];
        int affinity = int.Parse(monumentArgs[3]);

        Monument monument;
        switch (type)
        {
            case "Air":
                monument = new AirMonument(name, affinity);
                return monument;

            case "Water":
                monument = new WaterMonument(name, affinity);
                return monument;

            case "Fire":
                monument = new FireMonument(name, affinity);
                return monument;

            default:
                monument = new EarthMonument(name, affinity);
                return monument;
        }
    }
}






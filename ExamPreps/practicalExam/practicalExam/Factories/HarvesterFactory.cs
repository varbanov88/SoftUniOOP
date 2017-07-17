using System.Collections.Generic;

public static class HarvesterFactory
{
    public static Harvester GetHarvester(List<string> harvesterArgs)
    {
        var type = harvesterArgs[0];
        var id = harvesterArgs[1];
        var oreOutput = double.Parse(harvesterArgs[2]);
        var energyRequirement = double.Parse(harvesterArgs[3]);

        switch (type)
        {
            case "Hammer":
                Harvester harvester = new HammerHarvester(harvesterArgs[1], oreOutput, energyRequirement);
                return harvester;

            default:
                Harvester sonic = new SonicHarvester(id, oreOutput, energyRequirement, int.Parse(harvesterArgs[4]));
                return sonic;
        }
    }
}


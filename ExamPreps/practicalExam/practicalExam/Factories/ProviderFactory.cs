using System.Collections.Generic;

public static class ProviderFactory
{
    public static Provider GetProvider(List<string> providerArgs)
    {
        var type = providerArgs[0];
        var id = providerArgs[1];
        var energyOutput = double.Parse(providerArgs[2]);

        switch (type)
        {
            case "Solar":
                Provider provider = new SolarProvider(id, energyOutput);
                return provider;

            default:
                Provider pressureProvider = new PressureProvider(id, energyOutput);
                return pressureProvider;
        }
    }
}


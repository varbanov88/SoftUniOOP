using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;
    private string mode;
    private double totalEnergy;
    private double totalOre;
    private double dailyOrs;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.mode = "Full";
    }

    private double DailyOrs
    {
        get => this.dailyOrs;
        set { this.dailyOrs = value; }
    }

    private string EnergyMode
    {
        get => this.mode;
        set
        {
            this.mode = value;
        }
    }

    private double TotalEnergy
    {
        get => this.totalEnergy;
        set
        {
            this.totalEnergy = value;
        }
    }

    private double TotalOre
    {
        get => this.totalOre;
        set
        {
            this.totalOre = value;
        }
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var id = arguments[1];
        var type = arguments[0];

        try
        {
            Harvester harvester = HarvesterFactory.GetHarvester(arguments);
            harvesters.Add(id, harvester);
            return $"Successfully registered {type} Harvester - {id}";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        var id = arguments[1];
        var type = arguments[0];

        try
        {
            Provider provider = ProviderFactory.GetProvider(arguments);
            providers.Add(id, provider);
            return $"Successfully registered {type} Provider - {id}";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string Day()
    {
        double currEnergyProduced = 0;
        foreach (var prov in providers)
        {
            currEnergyProduced += prov.Value.EnergyOutput;
        }
        totalEnergy += currEnergyProduced;
        if (this.mode == "Energy")
        {
            var sbE = new StringBuilder();
            sbE.AppendLine("A day has passed.");
            sbE.AppendLine($"Energy Provided: {currEnergyProduced}");
            sbE.AppendLine($"Plumbus Ore Mined: 0");

            return sbE.ToString().Trim();
        }
        double currEnergyNeed = 0;
        double currOreMined = 0;
        if (this.mode == "Half")
        {
            foreach (var harv in harvesters)
            {

                currEnergyNeed += 0.6 * harv.Value.EnergyRequirement;
            }
            if (currEnergyNeed <= totalEnergy)
            {
                foreach (var harv in harvesters)
                {

                    currOreMined += 0.5 * harv.Value.OreOutput;
                }
                totalOre += currOreMined;
                totalEnergy -= currEnergyNeed;
            }
        }
        if (this.mode == "Full")
        {
            foreach (var harv in harvesters)
            {

                currEnergyNeed += harv.Value.EnergyRequirement;
            }
            if (currEnergyNeed <= totalEnergy)
            {
                foreach (var harv in harvesters)
                {

                    currOreMined += harv.Value.OreOutput;
                }
                totalOre += currOreMined;
                totalEnergy -= currEnergyNeed;
            }
        }

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {currEnergyProduced}");
        sb.AppendLine($"Plumbus Ore Mined: {currOreMined}");

        return sb.ToString().Trim();
    }

    private void HarvestDay(Dictionary<string, Harvester> harvesters)
    {
        switch (this.EnergyMode)
        {
            case "Half":
                this.TotalOre += harvesters.Values.Sum(h => h.OreOutput) * 50 / 100;
                this.DailyOrs = harvesters.Values.Sum(h => h.OreOutput) * 50 / 100;
                this.TotalEnergy -= harvesters.Values.Sum(h => h.EnergyRequirement) * 60 / 100;
                break;

            case "Full":
                this.TotalOre += harvesters.Values.Sum(h => h.OreOutput);
                this.DailyOrs = harvesters.Values.Sum(h => h.OreOutput);
                this.TotalEnergy -= harvesters.Values.Sum(h => h.EnergyRequirement);
                break;

        }
    }

    private double CalculateRequiredEnergy(string mode, Dictionary<string, Harvester> harvesters)
    {
        double reqEnergy = harvesters.Values.Sum(h => h.EnergyRequirement);
        if (this.mode == "Half")
        {
            reqEnergy = reqEnergy * 60 / 100;
        }
        return reqEnergy;
    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        if (providers.ContainsKey(id))
        {
            return providers[id].ToString();
        }
        else if (harvesters.ContainsKey(id))
        {
            return harvesters[id].ToString();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {totalEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {totalOre}");
        return sb.ToString().Trim();
    }

}


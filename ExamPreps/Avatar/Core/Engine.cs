using System;
using System.Linq;

public class Engine
{
    private NationsBuilder builder;

    public Engine()
    {
        this.builder = new NationsBuilder();
    }

    internal void Run()
    {
        string command;

        while((command = Console.ReadLine()) != "Quit")
        {
            ExecuteCommand(command);
        }

        ExecuteCommand(command);
    }

    private void ExecuteCommand(string command)
    {
        var cmdArgs = command.Split(' ');

        switch (cmdArgs[0])
        {
            case "Bender":
                builder.AssignBender(command.Split(' ').ToList());
                break;

            case "Monument":
                builder.AssignMonument(command.Split(' ').ToList());
                break;

            case "Status":
                Console.WriteLine(builder.GetStatus(cmdArgs[1]));
                break;

            case "War":
                builder.IssueWar(cmdArgs[1]);
                break;

            case "Quit":
                Console.WriteLine(builder.GetWarsRecord());                
                break;
        }
    }
}


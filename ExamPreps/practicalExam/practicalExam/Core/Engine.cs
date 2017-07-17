using System;
using System.Linq;

public class Engine
{
    private DraftManager manager;

    public Engine()
    {
        this.manager = new DraftManager();
    }

    public void Run()
    {
        string command;

        while ((command = Console.ReadLine()) != "Shutdown")
        {
            ExecuteCommand(command);
        }

        ExecuteCommand(command);
    }

    private void ExecuteCommand(string command)
    {
        var cmdArgs = command.Split(' ').ToList();

        switch (cmdArgs[0])
        {
            case "RegisterHarvester":
                cmdArgs.RemoveAt(0);
                Console.WriteLine(manager.RegisterHarvester(cmdArgs));
                break;

            case "RegisterProvider":
                cmdArgs.RemoveAt(0);
                Console.WriteLine(manager.RegisterProvider(cmdArgs));
                break;

            case "Mode":
                Console.WriteLine(manager.Mode(cmdArgs));
                break;

            case "Day":
                Console.WriteLine(manager.Day());
                break;

            case "Check":
                Console.WriteLine(manager.Check(cmdArgs));
                break;

            case "Shutdown":
                Console.WriteLine(manager.ShutDown());
                break;
        }
    }
}


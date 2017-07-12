using System;

public class Engine
{
    private CarManager manager;

    public Engine()
    {
        this.manager = new CarManager();
    }

    public void Run()
    {
        string command;

        while ((command = Console.ReadLine()) != "Cops Are Here")
        {
            var cmdArgs = command.Split(' ');
            ExecuteCommand(cmdArgs);
        }
    }

    private void ExecuteCommand(string[] cmdArgs)
    {
        int id = int.Parse(cmdArgs[1]);

        switch (cmdArgs[0])
        {
            case "register":
                var type = cmdArgs[2];
                var brand = cmdArgs[3];
                var model = cmdArgs[4];
                var productionYear = int.Parse(cmdArgs[5]);
                var horsepower = int.Parse(cmdArgs[6]);
                var acceleration = int.Parse(cmdArgs[7]);
                var suspension = int.Parse(cmdArgs[8]);
                var durability = int.Parse(cmdArgs[9]);

                manager.Register(id, type, brand, model, productionYear, horsepower, acceleration, suspension, durability);
                break;

            case "check":
                Console.WriteLine(manager.Check(id));
                break;

            case "open":
                type = cmdArgs[2];
                var length = int.Parse(cmdArgs[3]);
                var route = cmdArgs[4];
                var prizePool = int.Parse(cmdArgs[5]);

                manager.Open(id, type, length, route, prizePool);
                break;

            case "participate":
                var carId = int.Parse(cmdArgs[1]);
                var raceId = int.Parse(cmdArgs[2]);
                manager.Participate(carId, raceId);
                break;

            case "start":
                raceId = id;
                Console.WriteLine(manager.Start(id)); 
                break;

            case "park":
                manager.Park(id);
                break;

            case "unpark":
                manager.Unpark(id);
                break;

            case "tune":
                var tuneAddOn = cmdArgs[2];
                manager.Tune(id, tuneAddOn);
                break;

        }
    }
}


using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;
    private List<int> finishedRaces;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
        this.finishedRaces = new List<int>();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        Car car;
        if (type == "Performance")
        {
            car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            cars.Add(id, car);
        }

        else
        {
            car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            cars.Add(id, car);
        }
    }

    public string Check(int id)
    {
        var car = this.cars[id];
        return car.ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        Race race;
        switch (type)
        {
            case "Casual":
                race = new CasualRace(length, route, prizePool);
                this.races.Add(id, race);
                break;

            case "Drag":
                race = new DragRace(length, route, prizePool);
                this.races.Add(id, race);
                break;

            case "Drift":
                race = new DriftRace(length, route, prizePool);
                this.races.Add(id, race);
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (!this.garage.ParkedCars.ContainsKey(carId))
        {
            var race = this.races[raceId];
            var car = this.cars[carId];
            race.Participants.Add(carId, car);
        }
    }

    public string Start(int id)
    {
        Race race = races[id];
        if (races[id].Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }

        this.finishedRaces.Add(id);
        this.races.Remove(id);
        
        return race.ToString();
    }

    public void Park(int id)
    {
        foreach (var race in races.Values)
        {
            foreach (var car in race.Participants)
            {
                if (car.Key == id)
                {
                    return;
                }
            }
        }

        this.garage.ParkedCars.Add(id, cars[id]);
    }

    public void Unpark(int id)
    {
        if (this.garage.ParkedCars.ContainsKey(id))
        {
            this.garage.ParkedCars.Remove(id);
        }
    }

    public void Tune(int tuneIndex, string addOn)
    {
        if (this.garage.ParkedCars.Count > 0)
        {
            foreach (var car in this.garage.ParkedCars.Values)
            {
                car.Tune(tuneIndex, addOn);
            }
        }
    }

}


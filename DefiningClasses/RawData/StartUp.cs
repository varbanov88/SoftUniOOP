using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        var carsCount = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < carsCount; i++)
        {
            var carInfo = Console.ReadLine().Split();
            var model = carInfo[0];
            var engine = new Engine
            {
                Speed = int.Parse(carInfo[1]),
                Power = int.Parse(carInfo[2])
            };

            var cargo = new Cargo
            {
                Weight = int.Parse(carInfo[3]),
                Type = carInfo[4]
            };

            var tires = new List<Tire>();

            var firstTire = new Tire
            {
                Pressure = double.Parse(carInfo[5]),
                Age = int.Parse(carInfo[6])
            };
            tires.Add(firstTire);

            var secondTire = new Tire
            {
                Pressure = double.Parse(carInfo[7]),
                Age = int.Parse(carInfo[8])
            };
            tires.Add(secondTire);

            var thirdTire = new Tire
            {
                Pressure = double.Parse(carInfo[9]),
                Age = int.Parse(carInfo[10])
            };
            tires.Add(thirdTire);

            var fourthTire = new Tire
            {
                Pressure = double.Parse(carInfo[11]),
                Age = int.Parse(carInfo[12])
            };
            tires.Add(fourthTire);

            var car = new Car(model, engine, cargo, tires);
            cars.Add(car);
        }

        var command = Console.ReadLine();

        switch (command)
        {
            case "fragile":
                var resultFragile = cars
                                        .Where(c => c.Cargo.Type == "fragile" && c.Tires
                                            .Where(t => t.Pressure < 1)
                                            .FirstOrDefault() != null)
                                        .ToList();

                foreach (var carr in resultFragile)
                {
                    Console.WriteLine(carr.Model);
                }
                break;

            case "flamable":
                var result = cars.Where(c => c.Cargo.Type == "flamable")
                                 .Where(c => c.Engine.Power > 250)
                                 .ToList();

                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
                break;
        }
    }
}


using System;
using VehicleLibrary;
using VehicleLibrary.Enums;
using VehicleLibrary.Models;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicles!");
            Console.WriteLine("------------------------");

            Bicycle bicycle01 = new Bicycle()
            {
                Id = 1,
                Manufacturer = "Specialized",
                Model = "Sirrus",
                IsElectric = IsElectric.NotElectric,
                NumberOfWheels = 2,
                NumberOfSpeedLevels = 29,
            };

            bicycle01.Repair();
            bicycle01.Ride();
            bicycle01.PrintInfo();

            Console.WriteLine("------------------------");

            Car car01 = new Car()
            {
                Id = 2,
                Manufacturer = "Audi",
                Model = "A8",
                NumberOfWheels = 4,
                NumberOfDoors = 5,
                EngineType = EngineTypes.Diesel,
                FuelConsumption = 10,
                MaxSpeed = 250,
            };

            car01.Repair();
            car01.PrintInfo();
            car01.Drive();

            Console.WriteLine("------------------------");

            ElectricCar electric01 = new ElectricCar()
            {
                Id = 3,
                Manufacturer = "Tesla",
                Model = "Model 3",
                NumberOfWheels = 4,
                NumberOfDoors = 2,
                BatteryCapacity = 500,
                BatteryPercentage = 80,
                FuelConsumption = 0,
                MaxSpeed = 200,
            };

            electric01.PrintInfo();
            electric01.Repair();
            electric01.Recharge();

            Console.ReadLine();
        }
    }
}

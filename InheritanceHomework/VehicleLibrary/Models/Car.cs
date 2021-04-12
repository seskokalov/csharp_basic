using System;
using System.Collections.Generic;
using System.Text;
using VehicleLibrary.Enums;

namespace VehicleLibrary.Models
{
    public class Car : WheeledVehicle
    {
        public EngineTypes EngineType { get; set; }
        public WheeledVehicleTypes WheeledVehicle { get; set; }
        public int FuelConsumption { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }
        public EngineTypes Electric { get; }

        public Car()
        {

        }

        public Car(EngineTypes engineType, int fuelConsumption, int numberOfDoors, int maxSpeed) : base(WheeledVehicleTypes.Cars)
        {
            EngineType = engineType;
            FuelConsumption = fuelConsumption;
            NumberOfDoors = numberOfDoors;
            MaxSpeed = maxSpeed;
            WheeledVehicle = WheeledVehicleTypes.Cars;
        }

        public Car(EngineTypes type)
        {
            Electric = type;
        }

        public virtual void Drive()
        {
            Console.WriteLine($"Car {Model} is driving at a speed of {MaxSpeed} and it has type {Type}");
        }

        public virtual void Drive(EngineTypes electric)
        {
            Console.WriteLine($"Car {Model} is driving at a speed of {MaxSpeed}");
        }


    }
}

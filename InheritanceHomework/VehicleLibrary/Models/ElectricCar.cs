using System;
using System.Collections.Generic;
using System.Text;
using VehicleLibrary.Enums;

namespace VehicleLibrary.Models
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }

        public ElectricCar()
        {

        }

        public ElectricCar(int batteryCapacity, int batteryPercentage) : base(EngineTypes.Electric)
        {
            BatteryCapacity = batteryCapacity;
            BatteryPercentage = batteryPercentage;
            MaxSpeed = 99;
        }

        public void Recharge()
        {
            Console.WriteLine($"The car has {BatteryPercentage}% power left. It will now recharge to 100%.");
            BatteryPercentage = 100;
            Console.WriteLine($"Your car is now full {BatteryPercentage}%");
        }

        public override void Drive()
        {
            Console.WriteLine($"Car {Model} is driving at a speed of {MaxSpeed} because it is electric");
        }

    }
}

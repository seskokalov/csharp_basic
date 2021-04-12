using System;
using System.Collections.Generic;
using System.Text;
using VehicleLibrary.Enums;

namespace VehicleLibrary.Models
{
    public class Bicycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        public IsElectric IsElectric { get; set; }

        public Bicycle()
        {

        }

        public Bicycle(int numberOfSpeedLevels, IsElectric isElectric) : base(WheeledVehicleTypes.Bicycles)
        {
            NumberOfSpeedLevels = numberOfSpeedLevels;
            IsElectric = isElectric;
            Type = WheeledVehicleTypes.Bicycles;
        }

        public void Ride()
        {
            Console.WriteLine($"This is your new bike! It is super fast with {NumberOfSpeedLevels} levels");
        }

        public override void Repair()
        {
            Console.WriteLine($"Bicycle {Id}, model {Model}, is now fixed");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using VehicleLibrary.Enums;

namespace VehicleLibrary.Models
{
    public class WheeledVehicle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public WheeledVehicleTypes Type { get; set; }

        public WheeledVehicle()
        {

        }

        public WheeledVehicle(int numberOfWheels)
        {
            NumberOfWheels = numberOfWheels;
        }

        public WheeledVehicle(WheeledVehicleTypes type)
        {
            Type = type;
        }

        public virtual void Repair()
        {
            Console.WriteLine($"Vehicle id {Id}, has been repaired. You may stop by our workshop!");
        }
    }
}

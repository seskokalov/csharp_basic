using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Driver
    {
        public Driver()
        {
        }

        public string DriverName { get; set; }
        public int DriverSkill { get; set; }

        public Driver(string name, int skill)
        {
            DriverName = name;
            DriverSkill = skill;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Car
    {
        public Car()
        {
        }

        public Car(string model, int speed)
        {
            CarModel = model;
            CarSpeed = speed;
        }

        public string CarModel { get; set; }
        public int CarSpeed { get; set; }
        public Driver[] CarDriver { get; set; }

        public void RaceCars(Car firstCar, Car secondCar)
        {

        }
    }
}

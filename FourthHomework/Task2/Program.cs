using System;

namespace Task2
{
    class Program
    {
        static int CalculateSpeed(int speed, int skill)
        {
            return speed * skill;
        }

        static void RaceCars(string driver01, string car01, int speed01, int skill01, string driver02, string car02, int speed02, int skill02)
        {
            if (car01 == car02)
            {
                Console.WriteLine("Please select different cars for a more interesting race!");
            }
            else if (CalculateSpeed(speed01, skill01) > CalculateSpeed(speed02, skill02))
            {
                Console.WriteLine($"The {car01} won over the {car02}. The driver that won was {driver01} and was driving with a speed of {speed01}kmh");
            }
            else if (CalculateSpeed(speed01, skill01) < CalculateSpeed(speed02, skill02))
            {
                Console.WriteLine($"The {car02} won over the {car01}. The driver that won was {driver02} and was driving with a speed of {speed02}kmh");
            }
            else if (CalculateSpeed(speed01, skill01) == CalculateSpeed(speed02, skill02))
            {
                Console.WriteLine("It's a tie!");
            }
        }

        static Driver CheckDriver(Driver[] drivers, string driverSelection)
        {
            foreach (Driver driver in drivers)
            {
                if (driverSelection.ToLower() == driver.DriverName.ToLower()) return driver;
            }
            return null;
        }

        static Car CheckCar (Car[] cars, string carSelection)
        {
            foreach (Car car in cars)
            {
                if (carSelection.ToLower() == car.CarModel.ToLower()) return car;
            }
            return null;
        }

        static void Main(string[] args)
        {
            #region Task description
            //Make a class Driver. Add properties: Name, Skill
            //Make a class Car. Add properties: Model, Speed and Driver
            //Make a method of the Car class called : CalculateSpeed() that takes a driver object and calculates the skill multiplied by the speed of the car and return it as a result.
            //Make a method RaceCars() that will get two Car objects that will determine which car will win and print the result in the console.
            //Make 4 car objects and 4 driver objects.
            //Ask the user to select a two cars and two drivers for the cars. Add the drivers to the cars and call the RaceCars() methods
            //Test Data:
            //Choose a car no.1:
            //Hyundai
            //Mazda
            //Ferrari
            //Porsche
            //Choose Driver:
            //Bob
            //Greg
            //Jill
            //Anne
            //Choose a car no.2:
            //Hyundai
            //Mazda
            //Ferrari
            //Porsche
            //Choose Driver:
            //Bob
            //Greg
            //Jill
            //Anne
            //Expected Output:
            //Car no. 2 was faster.

            //BONUS 1: If a user chooses option one for the first care, eliminate that option when the user picks car two.

            //BONUS 2: Make the Output message say what was the model of the car that won, what speed was it going and which driver was driving it.

            //BONUS 3: Implement a Race Again Feature where you ask the user if he wants to race again and repeat the racing function.
            #endregion

            #region drivers
            Driver[] drivers = new Driver[]
            {
                new Driver("Pero", 3),
                new Driver("Trpe", 5),
                new Driver("Blazo", 8),
                new Driver("Branko", 1)
            };
            #endregion

            #region cars
            Car[] cars = new Car[]
            {
                new Car("Polo", 150),
                new Car("Golf", 190),
                new Car("Jetta", 210),
                new Car("Passat", 240),
            };
            #endregion

            #region first driver
            Console.WriteLine("Choose your car and drivers, find out who wins the race:");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Choose the first driver:");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {drivers[i].DriverName}");
            }

            string firstDriverSelection = Console.ReadLine();
            int driver01Skill = 0;
            //bool inputCheck = true;

            //while (inputCheck)
            //{
            Driver driver1 = CheckDriver(drivers, firstDriverSelection);
                if (driver1 == null)
                {
                    Console.WriteLine("Invalid input, try again! Use the name in the list.");
                    return;
                }
            Console.WriteLine($"Selected driver is: {driver1.DriverName}, driver skill level is: {driver1.DriverSkill}");
            firstDriverSelection = driver1.DriverName;
            driver01Skill = driver1.DriverSkill;
            //inputCheck = false;
            //} 

            //inputCheck = true;
            #endregion

            #region first car
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Choose the first car:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1} {cars[i].CarModel}");
            }

            string firstCarSelection = Console.ReadLine();
            int car01Speed = 0;

            //while (inputCheck)
            //{
                Car car1 = CheckCar(cars, firstCarSelection);
                if (car1 == null)
                {
                    Console.WriteLine("Invalid input, try again! Use the name in the list.");
                    return;
                }
                Console.WriteLine($"Selected car is: {car1.CarModel}, car's max speed is: {car1.CarSpeed}");
                firstCarSelection = car1.CarModel;
                car01Speed = car1.CarSpeed;
                //inputCheck = false;
            //}

            //inputCheck = true;
            #endregion

            #region second driver
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Choose the second driver:");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {drivers[i].DriverName}");
            }

            string secondDriverSelection = Console.ReadLine();
            int driver02Skill = 0;
            //inputCheck = true;

            //while (inputCheck)
            //{
                Driver driver2 = CheckDriver(drivers, secondDriverSelection);
                if (driver2 == null)
                {
                    Console.WriteLine("Invalid input, try again! Use the name in the list.");
                    return;
                }
                Console.WriteLine($"Selected driver is: {driver2.DriverName}, driver skill level is: {driver2.DriverSkill}");
                secondDriverSelection = driver2.DriverName;
                driver01Skill = driver2.DriverSkill;
                //inputCheck = false;
            //}

            //inputCheck = true;
            #endregion

            #region second car
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Choose the second car:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1} {cars[i].CarModel}");
            }

            string secondCarSelection = Console.ReadLine();
            int car02Speed = 0;

            //while (inputCheck)
            //{
                Car car2 = CheckCar(cars, secondCarSelection);
                if (car2 == null)
                {
                    Console.WriteLine("Invalid input, try again! Use the name in the list.");
                    return;
                }
                Console.WriteLine($"Selected car is: {car2.CarModel}, car's max speed is: {car2.CarSpeed}");
                secondCarSelection = car2.CarModel;
                car02Speed = car2.CarSpeed;
                //inputCheck = false;
            //}

            //inputCheck = true;
            #endregion

            Console.WriteLine("Selected cars and drivers will now race to the finish, press any button to continue");
            Console.ReadLine();

            RaceCars(firstDriverSelection, firstCarSelection, car01Speed, driver01Skill, secondDriverSelection, secondCarSelection, car02Speed, driver02Skill);

            Console.ReadLine();
        }
    }
}

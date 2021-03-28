using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number average calculator");

            double firstNumber;
            double secondNumber;
            double thirdNumber;
            double fourthNumber;

            Console.WriteLine("Enter the first number");
            bool firstInput = double.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter the second number");
            bool secondInput = double.TryParse(Console.ReadLine(), out secondNumber);
            Console.WriteLine("Enter the third number");
            bool thirdInput = double.TryParse(Console.ReadLine(), out thirdNumber);
            Console.WriteLine("Enter the fourth number");
            bool fourthInput = double.TryParse(Console.ReadLine(), out fourthNumber);
            if (firstInput && secondInput && thirdInput && fourthInput)
            {
                Console.WriteLine("The average of these numbers is: " + (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4);
            }
            else
            {
                Console.WriteLine("Wrong input! Try entering numbers only.");
            }

            Console.ReadLine();
        }
    }
}

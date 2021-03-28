using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Swap numbers app");

            int firstNumber = 0;
            int secondNumber = 0;
            int swapNumbers = 0;

            Console.WriteLine("Enter the first number");
            int.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Enter the second number");
            int.TryParse(Console.ReadLine(), out secondNumber);

            swapNumbers = secondNumber;
            secondNumber = firstNumber;
            firstNumber = swapNumbers; 

            Console.WriteLine("The first number is now second: " + firstNumber);
            Console.WriteLine("The second number is now first: " + secondNumber);
            

            Console.ReadLine();
        }
    }
}

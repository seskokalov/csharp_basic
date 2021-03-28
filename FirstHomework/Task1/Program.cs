using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple calculator app");

            #region Calculator

            int firstNumber = 0;
            int secondNumber = 0;
            char yourOperator;
            int result = 0;

            Console.WriteLine("Enter first number");
            int.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Enter second number");
            int.TryParse(Console.ReadLine(), out secondNumber);

            Console.WriteLine("Enter the operator  +, - , * , / ");
            char.TryParse(Console.ReadLine(), out yourOperator);

            switch (yourOperator)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("Enter a valid operator:  +, - , * , / ");
                    break;
            }

            Console.WriteLine("The result is: " + result);

            #endregion

            Console.ReadLine();
        }
    }
}

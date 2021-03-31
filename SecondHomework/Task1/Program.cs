using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers sum from array");

            //Make a console application called SumOfEven. Inside it create an array of 6 integers.Get numbers from the input, find and print the sum of the even numbers from the array:

            //Test Data:
            //Enter integer no.1:
            //4
            //Enter integer no.1:
            //3
            //Enter integer no.1:
            //7
            //Enter integer no.1:
            //3
            //Enter integer no.1:
            //2
            //Enter integer no.1:
            //8
            //Expected Output:
            //The result is: 14

            int[] myArray = new int[6];
            int sumOfEvenNumbers = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                bool ifSuccess = int.TryParse(Console.ReadLine(), out myArray[i]);
                if (ifSuccess)
                {
                    if (myArray[i] % 2 == 0)
                    {
                        sumOfEvenNumbers += myArray[i];
                    }
                } else
                {
                    Console.WriteLine("Invalid input, try again");
                    i--;
                }
            }

            Console.WriteLine("The sum of the entered even numbers is: " + sumOfEvenNumbers);

            Console.ReadLine();

        }
    }
}

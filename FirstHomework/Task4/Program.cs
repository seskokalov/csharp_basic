using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
        //Write a program, where for a given number entered via the keyboard, it will print:

        //"Tik" if divisible by 3,
        //"Tak" if divisible by 5,
        //"Tik - Tak" if divisible by 3 and 5.
        //If the number is not divisible by 3 or 5, then print "Bad number".

            Console.WriteLine("Find out if your number is divisible by 3, 5 or maybe both");

            int userInput = 0;

            Console.WriteLine("Enter your number: ");
            int.TryParse(Console.ReadLine(), out userInput);

            int check3 = userInput % 3;
            int check5 = userInput % 5;

            bool bool3 = false;
            bool bool5 = false;

            if (check3 == 0)
            {
                bool3 = true;
            }
            if (check5 == 0)
            {
                bool5 = true;
            }

            switch (bool3, bool5)
            {
                case (true, false):
                    Console.WriteLine("Tik");
                    break;
                case(false, true):
                    Console.WriteLine("Tak");
                    break;
                case(true, true):
                    Console.WriteLine("Tik - Tak");
                    break;
                default:
                    Console.WriteLine("Bad Number!");
                    break;
            }

            Console.ReadLine();
        }
    }
}

using System;
using Task3.Models;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task description
            //Create a class Student that has properties: Name, Academy and Group
            //●Create an array with 5 new Students(objects )
            //●The user should enter a name and the user information should be displayed in the console if a user by that name exists
            //●If there is no such user it should show an error message
            #endregion

            Students[] students = new Students[]
            {
                new Students("Pero", "Arts", "1"),
                new Students("Petranka", "Geology", "3"),
                new Students("Filimena", "Science", "4"),
                new Students("Risto", "Maths", "2"),
                new Students("Trpe", "Martial Arts", "5"),
            };


            while (true)
            {
                Console.WriteLine("Enter a student name to check if the student exists:");
                string userInput = Console.ReadLine();
                bool studentCheck = false;

                for (int i = 0; i < students.Length; i++)
                {
                    if (userInput.ToLower() == students[i].Name.ToLower())
                    {
                        Console.WriteLine($"The student {students[i].Name} is attending the {students[i].Academy} in the group {students[i].Group}");
                        studentCheck = true;
                    }
                }

                if (!studentCheck) Console.WriteLine("No such student, try again!");

                Console.WriteLine("-------------------------------");
                Console.WriteLine("Do you want to quit the program? Enter Q, or press Enter to continue checking.");
                string quitProgram = Console.ReadLine();
                if (quitProgram.ToLower() == "q") Environment.Exit(0);
            }

        }
    }
}

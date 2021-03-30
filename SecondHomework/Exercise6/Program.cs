using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 6");

            string[] names =
            {
                "Nikola",
                "Trajce",
                "Mihaela",
                "Zorica"
            };

            bool userChoice = true;

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            while (userChoice)
            {
                Console.WriteLine("Enter a name to add it in the list:");
                string newName = Console.ReadLine();
                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = newName;

                Console.WriteLine("Do you want to enter a new name? Y/N?");

                string confirm = Console.ReadLine();

                switch (confirm)
                {
                    case "Y":
                        continue;
                    case "N":
                        foreach (string name in names)
                        {
                            Console.WriteLine(name);
                        }
                        userChoice = false;
                        break;
                    default:
                        Console.WriteLine("You didnt enter Y or N. Try entering again, capital letters only");
                        userChoice = false;
                        continue;
                }
            }
            Console.ReadLine();
        }
    }
}

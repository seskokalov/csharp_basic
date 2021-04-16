using System;
using MovieStoreLibrary.Enums;
using MovieStoreLibrary.Models;
using MemberServices;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initial members
            int userCounter = 10;
            Random random = new Random();

            Employee employee01 = new Employee("Nikola", "Sheskokalov", 31, "seskokalov", "mnogujakpass", "070223305", DateTime.Parse("13 04 2000"));

            User user01 = new User("Ivana", "Krsteva", 28, "ivan4e", "usepojakpass", "078223305", DateTime.Parse("16 02 2019"), 1, Subscription.Monthly);
            User user02 = new User("Hans", "Gruber", 40, "hans", "hans123", "859652322", DateTime.Parse("01 04 2021"), 2, Subscription.Annual);

            List<Member> allMembers = new List<Member>
            {
                employee01,
                user01,
                user02
            };
            List<User> allUsers = new List<User>
            {
                user01,
                user02
            };
            List<Employee> allEmployees = new List<Employee>
            {
                employee01
            };

            #endregion

            #region movies
            List<Movie> allMovies = new List<Movie>
            {
                new Movie("John Wick", "Na site im ja krsi kicmata", 2014, MovieGenres.Action, IsRented.Rented),
                new Movie("Titanic", "All time classic", 1997, MovieGenres.Romance, IsRented.Available),
                new Movie("Two And a Half Men", "Family comedy", 2003, MovieGenres.TVShows, IsRented.Available),
                new Movie("Karate Kid", "A martial arts master agrees to teach karate to a bullied teenager.", 1984, MovieGenres.Action, IsRented.Rented),
                new Movie("The Curious Case of Benjamin Button", "Tells the story of Benjamin Button, a man who starts aging backwards with consequences.", 2008, MovieGenres.Drama, IsRented.Available),
                new Movie("Inception", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", 2010, MovieGenres.Thriller, IsRented.Available),
                new Movie("The Shawshank Redemption", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", 1994, MovieGenres.Drama, IsRented.Available),
                new Movie("The Dark Knight", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", 2008, MovieGenres.Action, IsRented.Rented)
            };

            #endregion

            #region Log In

            while (true)
            {
                Console.WriteLine("Hello!!! Welcome to our movie store!\n-----------------------------\nPlease log in:");
                Console.WriteLine("-------------------------- \nPlease choose one of the options.\n1) Employee\n2) User");

                bool logIn = int.TryParse(Console.ReadLine(), out int choice);
                if (choice == 1)
                {
                    #region Employee                                
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Employee\n-----------------");
                        Console.WriteLine($"If you want to go back to the previous menu, enter: q or enter anything else to continue");
                        string choiceEmployee = Console.ReadLine();
                        if (choiceEmployee.ToLower() == "q")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("WELCOME employee!!!!!\nPlease provide your credentials");
                                Console.WriteLine($"If you want to go back to the previous menu, enter: q or enter anything else to continue");

                                choiceEmployee = Console.ReadLine();
                                if (choiceEmployee.ToLower() == "q")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Enter your username:");
                                    string usernameEmployee = Console.ReadLine();
                                    Console.WriteLine("Enter your password:");
                                    string passEmployee = Console.ReadLine();
                                    Employee activeSessionEmployee;
                                    foreach (Employee item in allEmployees)
                                    {
                                        if (item.UserName == usernameEmployee && item.Password == passEmployee)
                                        {
                                            Console.Clear();
                                            activeSessionEmployee = item;
                                            Console.WriteLine($"Welcome back {item.FirstName}!!!");
                                            Console.WriteLine("-----------------------------------------------");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong username or password. Try Again! Press enter to continue");
                                            //Console.ReadLine();
                                            continue;
                                        }

                                        while (true)
                                        {
                                            Console.WriteLine($"If you want to log out enter: q or enter anything else to continue");
                                            Console.WriteLine($"Active user {activeSessionEmployee.UserName}");
                                            choiceEmployee = Console.ReadLine();
                                            if (choiceEmployee.ToLower() == "q")
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                            else
                                            {
                                                while (true)
                                                {
                                                    Console.WriteLine("Please select one of the options below:");
                                                    Console.WriteLine("1) See all the members");
                                                    Console.WriteLine("2) See all movies available. * - means movie is rented");
                                                    Console.WriteLine("3) Add a new employee");
                                                    Console.WriteLine("4) Add a new user");
                                                    Console.WriteLine("5) Delete existing member");
                                                    Console.WriteLine("6) Exit the app");
                                                    bool operationSelectEmployee = int.TryParse(Console.ReadLine(), out int operationEmployee);
                                                    if (operationEmployee == 1)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("All members are:");
                                                        MemberServices.EmployeeServices.SeeAllMembers(allMembers);
                                                        Console.WriteLine($"Press enter to continue");
                                                        choiceEmployee = Console.ReadLine();
                                                        Console.Clear();
                                                        break;

                                                    }
                                                    else if (operationEmployee == 2)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("All movies are:");
                                                        MemberServices.EmployeeServices.SeeAllMovies(allMovies);
                                                        choiceEmployee = Console.ReadLine();
                                                        Console.WriteLine($"Press enter to continue");
                                                        choiceEmployee = Console.ReadLine();
                                                        Console.Clear();
                                                        break;

                                                    }
                                                    else if (operationEmployee == 3)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Enter a first name");
                                                        string firstName = Console.ReadLine();
                                                        Console.WriteLine("Enter last name:");
                                                        string lastName = Console.ReadLine();
                                                        Console.WriteLine("Enter age:");
                                                        int age = 0;
                                                        while (true)
                                                        {
                                                            bool ageEntry = int.TryParse(Console.ReadLine(), out age);
                                                            if (ageEntry == false)
                                                            {
                                                                Console.WriteLine("Invalid number, try again");
                                                                continue;
                                                            }
                                                            else if (ageEntry == true)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        Console.WriteLine("Enter user name:");
                                                        string userName = (Console.ReadLine() + random.Next(10, 999999999));
                                                        Console.WriteLine("Enter a password:");
                                                        string password = Console.ReadLine();
                                                        Console.WriteLine("Enter phone number in the format XXX XXX XXX:");
                                                        string phoneNumber = Console.ReadLine();
                                                        DateTime dateOfRegistration = DateTime.Now;

                                                        MemberServices.EmployeeServices.AddNewEmployee(allEmployees, allMembers, firstName, lastName, age, userName, password, phoneNumber, dateOfRegistration);
                                                        Console.WriteLine($"All done! New member {userName} has been added!");
                                                        Console.WriteLine("-------------------------------------------------");
                                                        Console.WriteLine($"Press enter to continue");
                                                        choiceEmployee = Console.ReadLine();
                                                        Console.Clear();
                                                        break;

                                                    }
                                                    else if (operationEmployee == 4)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Enter a first name");
                                                        string firstName = Console.ReadLine();
                                                        Console.WriteLine("Enter last name:");
                                                        string lastName = Console.ReadLine();
                                                        Console.WriteLine("Enter age:");
                                                        int age = 0;
                                                        while (true)
                                                        {
                                                            bool ageEntry = int.TryParse(Console.ReadLine(), out age);
                                                            if (ageEntry == false)
                                                            {
                                                                Console.WriteLine("Invalid number, try again");
                                                                continue;
                                                            }
                                                            else if (ageEntry == true)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                        Console.WriteLine("Enter user name:");
                                                        string userName = (Console.ReadLine() + random.Next(10, 999999999));
                                                        Console.WriteLine("Enter a password:");
                                                        string password = Console.ReadLine();
                                                        Console.WriteLine("Enter phone number in the format XXX XXX XXX:");
                                                        string phoneNumber = Console.ReadLine();
                                                        DateTime dateOfRegistration = DateTime.Now;
                                                        Console.WriteLine("1) Monthly\n2) Annual");
                                                        bool subscriptionType = int.TryParse(Console.ReadLine(), out int subscriptionNumebr);
                                                        switch (subscriptionNumebr)
                                                        {
                                                            case 1:
                                                                subscriptionNumebr = 1;
                                                                break;
                                                            case 2:
                                                                subscriptionNumebr = 2;
                                                                break;
                                                            default:
                                                                break;
                                                        }
                                                        Subscription subscription = (Subscription)subscriptionNumebr;

                                                        MemberServices.EmployeeServices.AddNewUser(allUsers, allMembers, firstName, lastName, age, userName, password, phoneNumber, dateOfRegistration, userCounter, subscription);
                                                        userCounter++;
                                                        Console.WriteLine($"All done! New member {userName} has been added!");
                                                        Console.WriteLine("-------------------------------------------------");
                                                        Console.WriteLine($"Press enter to continue");
                                                        choiceEmployee = Console.ReadLine();
                                                        Console.Clear();
                                                        break;
                                                    }
                                                    else if (operationEmployee == 5)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Enter the username you want to delete:");
                                                        foreach (Member member in allMembers)
                                                        {
                                                            Console.WriteLine($" - {member.UserName}");
                                                        }
                                                        string userDelete = Console.ReadLine();
                                                        foreach (Member member in allMembers)
                                                        {
                                                            if (member.UserName == userDelete)
                                                            {
                                                                Console.WriteLine($"Success! {userDelete} has been deleted.");
                                                            }
                                                        }
                                                        MemberServices.EmployeeServices.DeleteMember(allMembers, allEmployees, allUsers, userDelete);
                                                        Console.WriteLine("Enter q to go back, or press enter to continue");
                                                        choiceEmployee = Console.ReadLine();
                                                        if (choiceEmployee.ToLower() == "q") Console.Clear();
                                                        break;
                                                    }
                                                    else if (operationEmployee == 6)
                                                    {
                                                        Console.Clear();
                                                        Environment.Exit(0);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }

                        }
                    }
                }
                #endregion

                #region User
                else if (choice == 2)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("User\n--------------------");
                        Console.WriteLine($"If you want to go back to the previous menu, enter: q or enter anything else to continue");
                        string choiceUser = Console.ReadLine();
                        if (choiceUser.ToLower() == "q")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            while (true)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("User menu\n");
                                Console.WriteLine("Please choose:\n1) Log In\n2) Register");
                                bool choiceUserMenu = int.TryParse(Console.ReadLine(), out int userMenu);
                                if (userMenu == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter your username:");
                                    string usernameUser = Console.ReadLine();
                                    Console.WriteLine("Enter your password:");
                                    string passUser = Console.ReadLine();
                                    User activeSessionUser;
                                    foreach (User item in allUsers)
                                    {
                                        if (item.UserName == usernameUser && item.Password == passUser)
                                        {
                                            Console.Clear();
                                            activeSessionUser = item;
                                            Console.WriteLine($"Welcome {item.FirstName}!!!");
                                            Console.WriteLine("-----------------------------------------------");
                                        }
                                        else 
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong username or password. Try Again! Press enter to continue");
                                            //Console.ReadLine();
                                            continue;
                                        }

                                        while (true)
                                        {
                                            Console.WriteLine("If you want to log out enter: q, otherwise press enter to continue");
                                            Console.WriteLine($"Active user {activeSessionUser.UserName}");
                                            choiceUser = Console.ReadLine();
                                            if (choiceUser.ToLower() == "q")
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                            else
                                            {
                                                while (true)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Select one of the following options");
                                                    Console.WriteLine("1) Check your subscription");
                                                    Console.WriteLine("2) Rent a movie");
                                                    Console.WriteLine("3) See the rented movies");
                                                    choiceUser = Console.ReadLine();
                                                    if (choiceUser == "1")
                                                    {
                                                        MemberServices.UserServices.CheckSubscription(activeSessionUser);
                                                        Console.WriteLine("Press enter to continue");
                                                        choiceUser = Console.ReadLine();
                                                        Console.Clear();
                                                        break;
                                                    }
                                                    else if (choiceUser == "2")
                                                    {
                                                        if (activeSessionUser.DateOfRegistration.AddYears(1) <= DateTime.Today || activeSessionUser.DateOfRegistration.AddMonths(1) <= DateTime.Today)
                                                        {
                                                            Console.WriteLine("No active subscription, please see a staff member to renew your substription");                    
                                                        }                                                        
                                                        else
                                                        {                                                            
                                                            Console.WriteLine("Please type in the name of the movie to rent. Note *-marked are not available");
                                                            MemberServices.EmployeeServices.SeeAllMovies(allMovies);
                                                            string movieChoice = Console.ReadLine();
                                                            MemberServices.UserServices.RentMovie(allMovies, allUsers, movieChoice, activeSessionUser.UserName);
                                                        }
                                                        Console.WriteLine("Press enter to continue");
                                                        choiceUser = Console.ReadLine();
                                                        Console.Clear();
                                                        break;
                                                    }
                                                    else if (choiceUser == "3")
                                                    {
                                                        MemberServices.UserServices.SeeRentedMovies(activeSessionUser);
                                                        Console.WriteLine("Press enter to continue");
                                                        choiceUser = Console.ReadLine();
                                                        Console.Clear();
                                                        break;
                                                    }
                                                    else if (choiceUser.ToLower() == "q")
                                                    {
                                                        Console.Clear();
                                                        Environment.Exit(0);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (userMenu == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter a first name");
                                    string firstName = Console.ReadLine();
                                    Console.WriteLine("Enter last name:");
                                    string lastName = Console.ReadLine();
                                    Console.WriteLine("Enter age:");
                                    int age = 0;
                                    while (true)
                                    {
                                        bool ageEntry = int.TryParse(Console.ReadLine(), out age);
                                        if (ageEntry == false)
                                        {
                                            Console.WriteLine("Invalid number, try again");
                                            continue;
                                        }
                                        else if (ageEntry == true)
                                        {
                                            break;
                                        }
                                    }
                                    Console.WriteLine("Enter user name:");
                                    string userName = (Console.ReadLine() + random.Next(10, 999999999));                                                                      
                                    Console.WriteLine("Enter a password:");
                                    string password = Console.ReadLine();
                                    Console.WriteLine("Enter phone number in the format XXX XXX XXX:");
                                    string phoneNumber = Console.ReadLine();
                                    DateTime dateOfRegistration = DateTime.Now;
                                    Console.WriteLine("1) Monthly\n2) Annual");
                                    bool subscriptionType = int.TryParse(Console.ReadLine(), out int subscriptionNumebr);
                                    switch (subscriptionNumebr)
                                    {
                                        case 1:
                                            subscriptionNumebr = 1;
                                            break;
                                        case 2:
                                            subscriptionNumebr = 2;
                                            break;
                                        default:
                                            break;
                                    }
                                    Subscription subscription = (Subscription)subscriptionNumebr;

                                    MemberServices.EmployeeServices.AddNewUser(allUsers, allMembers, firstName, lastName, age, userName, password, phoneNumber, dateOfRegistration, userCounter, subscription);
                                    userCounter++;
                                    Console.WriteLine($"All done! New member {userName} has been added! Go ahead and login now");
                                    Console.WriteLine("-------------------------------------------------");
                                    Console.WriteLine($"Press enter to continue");
                                    choiceUser = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Prevoius input was invalid! Try again!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    continue;
                                }
                            }
                        }

                    }
                }
                #endregion
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Prevoius input was invalid! Try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
            #endregion
        }
    }
}

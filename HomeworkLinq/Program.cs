using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLinq
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more
			List<Person> allPeopleAged50OrMore = people
										.Where(x => x.Age >= 50)
										.ToList();
            Console.WriteLine("All Persons aged 50 or more are:");
            foreach (Person item in allPeopleAged50OrMore)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine("---------------------------------------");
			// Task 02
			// all people name starts with B
			List<Person> nameStartsB = people
								.Where(x => x.FirstName.StartsWith("B"))
								.ToList();
            Console.WriteLine("Persons whose name starts with B are:");
            foreach (Person item in nameStartsB)
            {
                Console.WriteLine(item.FirstName);
            }
			Console.WriteLine("---------------------------------------");
			// Task 03
			// first person whose surname starts with T
			List<Person> lastnameStartsWithT = people
										.Where(x => x.LastName.StartsWith("T"))
										.ToList();
            Console.WriteLine("Persons whose lastname starts with T are:");
            foreach (Person item in lastnameStartsWithT)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
			Console.WriteLine("---------------------------------------");
			// Task 04
			// find youngest and oldest person
			Person youngest = people
							.Where(x => x.Age == people.Select(x => x.Age).Min())
							.FirstOrDefault();
			Person oldest = people
							.Where(x => x.Age == people.Select(x => x.Age).Max())
							.FirstOrDefault();

			Console.WriteLine($"The youngest is {youngest.FirstName} with age of {youngest.Age} while the oldest person is {oldest.FirstName} with age of {oldest.Age}");
			Console.WriteLine("---------------------------------------");

			// Task 05
			// find all male people aged 45 or more
			List<Person> allMaleAged45 = people
								.Where(x => x.Gender == 'M')
								.Where(x => x.Age > 44)
								.ToList();
            Console.WriteLine("All male aged 45 or more are:");
            foreach (Person item in allMaleAged45)
            {
                Console.WriteLine(item.FirstName);
            }
			Console.WriteLine("---------------------------------------");
			// Task 06
			// find all females whose name starts with V
			List<Person> allFemalesNameV = people
									.Where(x => x.Gender == 'F')
									.Where(x => x.FirstName.StartsWith("V"))
									.ToList();
            Console.WriteLine("All females aged 45 or more and name starts with V are:");
            foreach (Person item in allFemalesNameV)
            {
                Console.WriteLine(item.FirstName);
            }
			Console.WriteLine("---------------------------------------");
			// Task 07
			// find last female person older than 30 whose name starts with p
			Person lastFemaleAged30NameP = people
										.Where(x => x.Gender == 'F')
										.Where(x => x.Age >= 30)
										.Where(x => x.FirstName == "P")
										.LastOrDefault();
            Console.WriteLine(lastFemaleAged30NameP);
			Console.WriteLine("---------------------------------------");
			// Task 08
			// find first male younger than 40
			Person firstMaleYounger40 = people
									.Where(x => x.Age > 40).FirstOrDefault();
            Console.WriteLine(firstMaleYounger40.FirstName);
			Console.WriteLine("---------------------------------------");
			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			List<Person> firstNameLonger = people
									.Where(x => x.FirstName.Length > x.LastName.Length)
									.ToList();
            Console.WriteLine("People with first names longer than their last names are:");
            foreach (Person item in firstNameLonger)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
			Console.WriteLine("---------------------------------------");
			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			List<Person> lastNamesFemalesOddNumberAge = people
												.Where(x => x.Gender == 'F')
												.Where(x => x.Age % 2 == 1)
												.ToList();
            Console.WriteLine("Last names of females with odd numbers of age");
            foreach (Person item in lastNamesFemalesOddNumberAge)
            {
                Console.WriteLine($"{item.FirstName} aged {item.Age}");
            }

			Console.ReadLine();
		}
    }
}

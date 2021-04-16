using System;
using MovieStoreLibrary.Enums;
using MovieStoreLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace MemberServices
{
    public static class EmployeeServices
    {
        public static void SeeAllMembers(List<Member> list)
        {
            foreach (Member item in list)
            {
                item.DisplayInfo();
            }
        }

        public static void SeeAllMovies(List<Movie> list)
        {
            foreach (Movie item in list)
            {
                if(item.Available == IsRented.Rented)
                {
                    Console.WriteLine(item.Title + "*");
                } else
                {
                    Console.WriteLine(item.Title);
                }
            }
        }
                
        public static void AddNewEmployee(List<Employee> list1, List<Member> list2, string firstName, string lastName, int age, string userName, string password, string phoneNumber, DateTime dateOfRegistration)
        {
            Employee newEmployee = new Employee(firstName, lastName, age, userName, password, phoneNumber, dateOfRegistration);
            list1.Add(newEmployee);
            list2.Add(newEmployee);
        }
              

        public static void AddNewUser(List<User> list1, List<Member> list2, string firstName, string lastName, int age, string userName, string password, string phoneNumber, DateTime dateOfRegistration, int memberNumber, Subscription subscription)
        {
            User newUser = new User(firstName, lastName, age, userName, password, phoneNumber, dateOfRegistration, memberNumber, subscription);
            list1.Add(newUser);
            list2.Add(newUser);
        }


        public static void DeleteMember(List<Member> list1, List<Employee> list2, List<User> list3, string userName)
        {
            foreach (Member item in list1.ToList())
            {
                if (userName == item.UserName)
                {
                    list1.Remove(item);
                }
            }
            foreach (Employee item in list2.ToList())
            {
                if (userName == item.UserName)
                {
                    list2.Remove(item);
                }
            }
            foreach (User item in list3.ToList())
            {
                if (userName == item.UserName)
                {
                    list3.Remove(item);
                }
            }
        }
    }
}

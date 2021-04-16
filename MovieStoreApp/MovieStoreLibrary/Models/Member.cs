using MovieStoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary.Models
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Roles Role { get; set; }

        public Member(string firstName, string lastName, int age, string userName, string password, string phoneNumber, DateTime dateOfRegistration)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
        }

        public Member()
        {

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"User info: {FirstName} {LastName} | Registered on: {DateOfRegistration}");
        }
    }
}

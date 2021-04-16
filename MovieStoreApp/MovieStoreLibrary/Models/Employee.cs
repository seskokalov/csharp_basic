using MovieStoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace MovieStoreLibrary.Models
{
    public class Employee : Member
    {
        private double Salary { get; set; }
        public int HoursPerMonth { get; set; }
        private double Bonus { get; set; }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, int age, string userName, string password, string phoneNumber, DateTime dateOfRegistration)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            Role = Roles.Employee;
            Salary = 300;
        }

        private void SetBonus(int hoursPerMonth)
        {
            HoursPerMonth = hoursPerMonth;
            if (HoursPerMonth > 160)
                Bonus = 0.3;
            else
                Bonus = 0;
            SetSalary();
        }

        private double SetSalary()
        {
            Salary = Salary + Bonus * HoursPerMonth;
            return Salary;
        }
    }
}

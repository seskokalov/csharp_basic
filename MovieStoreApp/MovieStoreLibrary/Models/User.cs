using MovieStoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary.Models
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public Subscription SubscriptionType { get; set; }
        public List<Movie> RentedMovies { get; set; } = new List<Movie>();

        public User()
        {

        }

        public User(string firstName, string lastName, int age, string userName, string password, string phoneNumber, DateTime dateOfRegistration, int memberNumber, Subscription subscription)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            Role = Roles.User;
            MemberNumber = memberNumber;
            SubscriptionType = subscription;
        }
    }
}

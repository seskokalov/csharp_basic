using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;
using MovieStoreLibrary.Models;
using System.Linq;

namespace MemberServices
{
    public static class UserServices
    {
        public static void CheckSubscription(User user)
        {
            if (user.SubscriptionType == Subscription.Annual && user.DateOfRegistration.AddYears(1) >= DateTime.Today) 
            {
                Console.WriteLine($"You have the {user.SubscriptionType} subscription! Your subscription is active until {user.DateOfRegistration.AddYears(1)}");
            }
            else if (user.SubscriptionType == Subscription.Monthly && user.DateOfRegistration.AddMonths(1) >= DateTime.Today)
            {
                Console.WriteLine($"You have the {user.SubscriptionType} subscription! Your subscription is active until {user.DateOfRegistration.AddMonths(1)}");
            }
            else
            {
                Console.WriteLine("No active subscription");
            }
        }

        public static void RentMovie(List<Movie> allMovies, List<User> user, string movieChoice, string userName)
        {
            foreach (Movie movie in allMovies)
            {
                if (movie.Title.ToLower() == movieChoice.ToLower())
                {
                    movie.Available = IsRented.Rented;
                    foreach (User item in user)
                    {
                        if (item.UserName == userName)
                            item.RentedMovies.Add(movie);
                        
                    }
                }
            }

        }
                
        public static void SeeRentedMovies(User activeUser)
        {
            int counter = 0;
            foreach (Movie item in activeUser.RentedMovies)
            {                
                counter++;
                Console.WriteLine($"{counter} {item.Title}");
            }
        }
    }
}

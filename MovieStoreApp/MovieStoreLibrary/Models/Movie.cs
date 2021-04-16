using MovieStoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public MovieGenres Genre { get; set; }
        public int Price { get; set; }
        public IsRented Available { get; set; }

        public Movie()
        {

        }

        public Movie(string title, string description, int year, MovieGenres genre, IsRented available)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            SetPrice();
            Available = available;
        }

        private void SetPrice()
        {
            Random random = new Random();
            if (Year <= 2000)
            {
                Price = random.Next(1, 100);
            }
            if (Year > 2000 && Year <= 2010)
            {
                Price = random.Next(100, 200);
            }
            else
            {
                Price = random.Next(200, 300);
            }
        }
    }
}

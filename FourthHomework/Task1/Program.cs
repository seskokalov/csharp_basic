using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the current date with time
            //Print the date that is 10 years from now
            //Print the date that is 2 months and 15 days ago
            //Print day of week for the next 8 - th March
            //Print day of week of last year's Valentine's day

            Console.WriteLine("Print the current date with time");
            DateTime currentDateWithTime = DateTime.Now;
            Console.WriteLine(currentDateWithTime);
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Print the date that is 10 years from now");
            DateTime tenYearsFromNow = DateTime.Today.AddYears(10);
            Console.WriteLine(tenYearsFromNow);
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Print the date that is 2 months and 15 days ago");
            DateTime twoMonths15DaysAgo = DateTime.Today.AddMonths(-2).AddDays(-15);
            Console.WriteLine(twoMonths15DaysAgo);
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Print day of week for the next 8 - th March");
            DateTime nextWomansDay = DateTime.Parse("08.03").AddYears(1);
            Console.WriteLine(nextWomansDay.DayOfWeek);
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Print day of week of last year's Valentine's day");
            DateTime valentinesDay = DateTime.Parse("14.02").AddYears(-1);
            Console.WriteLine(valentinesDay.DayOfWeek);
            Console.WriteLine("-------------------------------");

            Console.ReadLine();
        }
    }
}

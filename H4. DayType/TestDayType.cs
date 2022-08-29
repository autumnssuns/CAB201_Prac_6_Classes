using System;
using System.Collections.Generic;
using System.Text;

namespace DayType
{

    /// <summary>
    /// A class to test the day type class.
    /// </summary>
    class TestDayType
    {

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            DayType day = new DayType(0);
            Console.WriteLine("Day is one " + day.Day); // check that day = 1 
            day.Day = 7;
            Console.WriteLine("Day is eight " + day.Day); // check that day = 7
            day.Day = 14;
            Console.WriteLine("Day is fourteen " + day.Day); // check that day = 14
            day.Day = 15;
            Console.WriteLine("Day is fifteen " + day.Day); // check that day = 15 

            Console.WriteLine("Day is Monday " + day.ReturnDay()); // check that the day is Monday

            Console.WriteLine("Tomorrow is Tuesday " + day.NextDay()); // check that the the next day is Tuesday

            Console.WriteLine("Yesterday was Sunday " + day.PreviousDay()); // check that the previous day was Sunday

            day.Day = 6;
            Console.WriteLine("Is today was Saturday tomorrow is Sunday " + day.NextDay()); // check that the  next day is Sunday if the previous day was Saturday

            day.Day = 0;
            Console.WriteLine("Is today was Sunday yesterday was Saturday " + day.PreviousDay()); // check that the next day is Saturday if the previous day was Sunday

            day.Day = 1;
            Console.WriteLine("Day is Monday, add 4 days,  return day is Friday " + day.NextDay(4)); // check that the next day is Friday is the day is Monday and we add 4 days 

            day.Day = 2;
            Console.WriteLine("Day is Tuesday, add 13 days,  return day is Monday " + day.NextDay(13)); // check that the next day is Monday is the day is Tuesday and we add 13 days 


        }
    }
}
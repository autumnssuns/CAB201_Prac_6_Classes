using System;

namespace DayType
{
    /// <summary>
    /// A class to model the days of the week.
    /// </summary>
    class DayType
    {
        /// <summary>
        /// The days of the week.
        /// </summary>
        private string[] daysOfWeek = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        /// <summary>
        /// The day/
        /// </summary>
        private int day;

        /// <summary>
        /// The day.
        /// </summary>
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value % 7;
            }
        }

        /// <summary>
        /// The day.
        /// </summary>
        /// <param name="day">A day representing 0..n.</param>
        public DayType(int day)
        {
            this.day = day % 7;
        }

        /// <summary>
        /// Returns the day.
        /// </summary>
        /// <returns>The day of the week.</returns>
        public string ReturnDay()
        {
            return daysOfWeek[day];
        }

        /// <summary>
        /// Returns the next day.
        /// </summary>
        /// <returns>The next day of the week.</returns>
        public string NextDay()
        {
            // if day is equal to 6 then return 0
            if (day == 6)
            {
                return daysOfWeek[0];
            }

            return daysOfWeek[day + 1];
        }

        /// <summary>
        /// Returns the previous day.
        /// </summary>
        /// <returns>The previous day of the week.</returns>
        public string PreviousDay()
        {
            // if day is equal to 0 then return 6
            if (day == 0)
            {
                return daysOfWeek[6];
            }

            return daysOfWeek[day - 1];
        }

        /// <summary>
        /// Returns the day where N is the number of days after the current day. 
        /// </summary>
        /// <param name="nextDay">A day represeting the N number of days.</param>
        /// <returns>The day where N is the number of days after the current day.</returns>
        public string NextDay(int nextDay)
        {
            int newDay = (day + nextDay) % 7;
            return daysOfWeek[newDay];
        }

    }
}

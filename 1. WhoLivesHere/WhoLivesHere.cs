using System;

namespace WhoLivesHere
{
    /// <summary>
    /// A class containing a person's name and city.
    /// </summary>
    class WhoLivesHere
    {
        /// <summary>
        /// The name of the person.
        /// </summary>
        string name;

        /// <summary>
        /// The city the person lives in.
        /// </summary>
        string city;

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            WhoLivesHere andy = new WhoLivesHere();
            andy.name = "Andy";
            andy.city = "Brisbane";

            WhoLivesHere kevin = new WhoLivesHere();
            kevin.name = "Kevin";
            kevin.city = "Melbourne";

            Console.WriteLine($"{andy.name} lives in {andy.city}");
            Console.WriteLine($"{kevin.name} lives in {kevin.city}");
        }
    }
}
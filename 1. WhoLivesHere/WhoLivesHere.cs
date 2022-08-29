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

        WhoLivesHere(string newName, string newCity)
        {
            name = newName;
            city = newCity;
        }

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            WhoLivesHere andy = new WhoLivesHere("Andy", "Brisbane");
            WhoLivesHere kevin = new WhoLivesHere("Kevin", "Melbourne");

            Console.WriteLine($"{andy.name} lives in {andy.city}");
            Console.WriteLine($"{kevin.name} lives in {kevin.city}");
        }
    }
}
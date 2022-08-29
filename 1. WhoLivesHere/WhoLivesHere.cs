using System;

namespace WhoLivesHere
{
    /// <summary>
    /// A class containing a person's name and city.
    /// </summary>
    class WhoLivesHere
    {
        /// <summary>
        /// The person's name.
        /// </summary>
        string name;

        /// <summary>
        /// The person's city.
        /// </summary>
        string city;

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            WhoLivesHere whom1 = new WhoLivesHere();
            whom1.name = "Sally";
            whom1.city = "Brisbane";
            Console.WriteLine(whom1.name + " " + whom1.city);

            WhoLivesHere whom2 = new WhoLivesHere();
            whom2.name = "Charlie";
            whom2.city = "New York";
            Console.WriteLine(whom2.name + " " + whom2.city);

            WhoLivesHere whom3 = new WhoLivesHere();
            whom3.name = "Johnny";
            whom3.city = "London";
            Console.WriteLine(whom3.name + " " + whom3.city);

        }
    }
}
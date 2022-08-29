using System;
using System.Collections.Generic;

namespace WhoLivesHere
{
    /// <summary>
    /// A class containing a person's name and city.
    /// </summary>
    class WhoLivesHere
    {
        string name;
        string city;
        int age;

        WhoLivesHere(string newName, string newCity, int newAge)
        {
            Console.WriteLine($"Creating person: {newName}");
            name = newName;
            city = newCity;
            age = newAge;
        }

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            List<WhoLivesHere> list = new List<WhoLivesHere>();

            WhoLivesHere superTutor = new WhoLivesHere("Lawrence", "Brisbane", 50);
            list.Add(superTutor);

            WhoLivesHere visitor = new WhoLivesHere("Timothy", "Adelaide", 42);
            list.Add(visitor);

            WhoLivesHere tutor = new WhoLivesHere("Dan", "Sydney", 21);
            list.Add(tutor);

            foreach (WhoLivesHere person in list)
            {
                Console.WriteLine($"{person.name} lives in {person.city}");
            }
        }
    }
}

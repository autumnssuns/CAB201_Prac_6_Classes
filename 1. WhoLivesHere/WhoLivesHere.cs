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

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            List<WhoLivesHere> list = new List<WhoLivesHere>();

            WhoLivesHere superTutor = new WhoLivesHere();
            superTutor.name = "Lawrence";
            superTutor.city = "Brisbane";
            superTutor.age = 50;
            list.Add(superTutor);

            WhoLivesHere visitor = new WhoLivesHere();
            visitor.name = "Timothy";
            visitor.city = "Adelaide";
            visitor.age = 42;
            list.Add(visitor);

            WhoLivesHere tutor = new WhoLivesHere();
            tutor.name = "Dan";
            tutor.city = "Sydney";
            tutor.age = 21;
            list.Add(tutor);

            foreach (WhoLivesHere person in list)
            {
                Console.WriteLine($"{person.name} lives in {person.city}");
            }
        }
    }
}

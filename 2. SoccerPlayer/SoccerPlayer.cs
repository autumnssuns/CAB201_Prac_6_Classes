using System;

namespace SoccerPlayer
{
    /// <summary>
    /// A class containing a soccer player. 
    /// </summary>
    class SoccerPlayer
    {
        /// <summary>
        /// The soccer player's name.
        /// </summary>
        string name;

        /// <summary>
        /// The soccer player's number.
        /// </summary>
        int number;

        /// <summary>
        /// The soccer player's goals scored.
        /// </summary>
        int goals_scored;

        /// <summary>
        /// The soccer player's goal assists.
        /// </summary>
        int assists;

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            SoccerPlayer beckham = new SoccerPlayer();
            beckham.name = "David Beckham";
            beckham.number = 7;
            beckham.goals_scored = 10;
            beckham.assists = 5;
            Console.WriteLine(beckham.name + " " + beckham.number + " " + beckham.goals_scored + " " + beckham.assists);

            SoccerPlayer ronaldo = new SoccerPlayer();
            ronaldo.name = "Cristiano Ronaldo";
            ronaldo.number = 7;
            ronaldo.goals_scored = 20;
            ronaldo.assists = 15;
            Console.WriteLine(ronaldo.name + " " + ronaldo.number + " " + ronaldo.goals_scored + " " + ronaldo.assists);


            SoccerPlayer best = new SoccerPlayer();
            best.name = "George Best";
            best.number = 7;
            best.goals_scored = 25;
            best.assists = 10;
            Console.WriteLine(best.name + " " + best.number + " " + best.goals_scored + " " + best.assists);

        }
    }
}
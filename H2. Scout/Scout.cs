using System;

namespace Scout
{
    /// <summary>
    /// A class to model a scout
    /// </summary>
    class Scout
    {

        /// <summary>
        /// The scout's name.
        /// </summary>
        string name;

        /// <summary>
        /// The scout's troop number.
        /// </summary>
        int troopNumber;

        /// <summary>
        /// The scout's dues.
        /// </summary>
        double dues;

        /// <summary>
        /// The model of the scout.
        /// </summary>
        /// <param name="myName">The scout's name.</param>
        /// <param name="myTroopNumber">The scout's troop number.</param>
        /// <param name="myDues">The scout's dues.</param>
        public Scout(string myName, int myTroopNumber, double myDues)
        {
            name = myName;
            troopNumber = myTroopNumber;
            dues = myDues;
        }


        /// <summary>
        /// The model of the scout.
        /// </summary>
        /// <param name="myName">The scout's name.</param>
        /// <param name="myTroopNumber">The scout's troop number.</param>
        public Scout(string myName, int myTroopNumber)
        {
            name = myName;
            troopNumber = myTroopNumber;
            dues = 0;
        }


        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            Scout jon = new Scout("Jon", 42, 1000);
            Console.WriteLine(jon.name + " " + jon.troopNumber + " " + jon.dues);

            Scout robb = new Scout("Robb", 13);
            Console.WriteLine(robb.name + " " + robb.troopNumber + " " + robb.dues);


        }
    }
}
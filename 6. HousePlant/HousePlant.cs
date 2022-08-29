using System;

namespace HousePlant
{
    /// <summary>
    /// Models a house plant.
    /// </summary>
    class HousePlant
    {
        /// <summary>
        /// The plant's name.
        /// </summary>
        string name { get; set; }

        /// <summary>
        /// The plant's price.
        /// </summary>
        double price { get; set; }

        /// <summary>
        /// Says if the plant is fed or not.
        /// </summary>
        bool fed { get; set; }

        /// <summary>
        /// The house plants model
        /// </summary>
        /// <param name="name">The plant's name.</param>
        /// <param name="price">The plant's price.</param>
        /// <param name="fed">Says if the plant is fed or not.</param>
        HousePlant(string name, double price, bool fed)
        {
            this.name = name;
            this.price = price;
            this.fed = fed;
        }

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            HousePlant plant = new HousePlant("Philodendron", 29.99, true);
            Console.WriteLine(plant.name + " " + plant.price + " " + plant.fed);
            plant.price = 19.99;
            plant.fed = false;
            Console.WriteLine(plant.name + " " + plant.price + " " + plant.fed);

        }
    }
}
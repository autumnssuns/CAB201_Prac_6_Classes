using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePlant
{
    internal class Program
    {
        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            HousePlant plant = new HousePlant("Philodendron", 29.99, true);
            plant.isFed = false;
            Console.WriteLine($"{plant.name}, {plant.Price}, fed: {plant.isFed}");
            Console.WriteLine($"{plant.name}, {plant.Price}, fed: {plant.isFed}");
            Console.WriteLine($"{plant.name}, {plant.Price}, fed: {plant.isFed}");
            Console.WriteLine($"{plant.name}, {plant.Price}, fed: {plant.isFed}");
            Console.WriteLine($"{plant.name}, {plant.Price}, fed: {plant.isFed}");
            Console.WriteLine($"{plant.name}, {plant.Price}, fed: {plant.isFed}");
            Console.WriteLine($"{plant.name}, {plant.Price}, fed: {plant.isFed}");
            Console.WriteLine($"{plant.name}, {plant.Price}, fed: {plant.isFed}");
        }
    }
}

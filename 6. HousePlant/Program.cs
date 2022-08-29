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
        HousePlant myPlant = new HousePlant("Philodendron", 29.99, true);
        myPlant.PlantPrice = -300.99;
        myPlant.isFed = false;
        Console.WriteLine($"{myPlant.plantName}, {myPlant.PlantPrice:C}, fed: {myPlant.isFed}");
        Console.WriteLine($"{myPlant.plantName}, {myPlant.PlantPrice:C}, fed: {myPlant.isFed}");
        Console.WriteLine($"{myPlant.plantName}, {myPlant.PlantPrice:C}, fed: {myPlant.isFed}");
            myPlant.AddTag("-Pricy");
        Console.WriteLine($"{myPlant.plantName}, {myPlant.PlantPrice:C}, fed: {myPlant.isFed}");
        Console.WriteLine($"{myPlant.plantName}, {myPlant.PlantPrice:C}, fed: {myPlant.isFed}");
        Console.WriteLine($"{myPlant.plantName}, {myPlant.PlantPrice:C}, fed: {myPlant.isFed}");
    }
}
}

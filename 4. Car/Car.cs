using System;

namespace Car
{
    /// <summary>
    /// A class to hold details of a car
    /// The Car should contain two fields, a model and a litres per kilometre.
    /// </summary>
    class Car
    {
        string model;
        int litresPerKm;

        Car(string model, int litresPerKm)
        {
            this.model = model;
            this.litresPerKm = litresPerKm;
        }
        // A different way to write the second (1-parameter) constructor
        // by using the old (2-parameter) constructor
        Car(string model) : this(model, 50) { }

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            Car mazda = new Car("Mazda 3", 7);
            Console.WriteLine($"{mazda.model} consumes {mazda.litresPerKm} litres / km");

            Car toyota = new Car("Toyota");
            Console.WriteLine($"{toyota.model} consumes {toyota.litresPerKm} litres / km");
        }
    }
}

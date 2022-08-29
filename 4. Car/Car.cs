using System;

namespace Car
{
    /// <summary>
    /// A class to hold details of a car
    /// </summary>
    class Car
    {
        /// <summary>
        /// The model of the car.
        /// </summary>
        string model;

        /// <summary>
        /// The fuel consumption in litres per km.
        /// </summary>
        double litresPerKm;

        Car(string newModel, double newLitresPerKm)
        {
            model = newModel;
            litresPerKm = newLitresPerKm;
        }

        Car(string newModel)
        {
            model = newModel;
            litresPerKm = 50;
        }

        Car()
        {
            Console.WriteLine("No model was found, please enter one:");
            model = Console.ReadLine();
            litresPerKm = 50;
        }

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            Car mazda = new Car("Mazda 3", 7);
            Console.WriteLine($"The model {mazda.model} consumes {mazda.litresPerKm} litres of fuel per km.");

            Car honda = new Car("Honda");
            Console.WriteLine($"The model {honda.model} consumes {honda.litresPerKm} litres of fuel per km.");

            Car unknownCar = new Car();
            Console.WriteLine($"The model {unknownCar.model} consumes {unknownCar.litresPerKm} litres of fuel per km.");
        }
    }
}

using System;

namespace Car
{
    /// <summary>
    /// A class to hold details of a car
    /// </summary>
    class Car
    {
        /// <summary>
        /// The car's model.
        /// </summary>
        string model;

        /// <summary>
        /// The car's liter/km.
        /// </summary>
        double literPerKm;

        /// <summary>
        /// Constructs a car.
        /// </summary>
        /// <param name="myModel">The car's model</param>
        public Car(string myModel)
        {
            model = myModel;
            literPerKm = 50;
        }

        /// <summary>
        /// Constructs a car.
        /// </summary>
        /// <param name="myModel">The car's model</param>
        /// <param name="myLiterPerKm">The car's liter/km.</param>
        public Car(string myModel, double myLiterPerKm)
        {
            model = myModel;
            literPerKm = myLiterPerKm;
        }

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            Car car1 = new Car("Jager");
            Car car2 = new Car("Ford", 25);
            Car car3 = new Car("Holden", 100);

            Console.WriteLine(car1.model + " " + car1.literPerKm);
            Console.WriteLine(car2.model + " " + car2.literPerKm);
            Console.WriteLine(car3.model + " " + car3.literPerKm);
        }
    }
}
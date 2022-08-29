using System;

namespace Pizza
{
    /// <summary>
    /// A class to model pizza.
    /// </summary>
    class Pizza
    {
        /// <summary>
        /// The pizza's toppings.
        /// </summary>
        string toppings;

        /// <summary>
        /// The pizza's diameter.
        /// </summary>
        int diameter;

        /// <summary>
        /// The pizza's price.
        /// </summary>
        double price;

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            Pizza pineapple = new Pizza();
            pineapple.toppings = "Pineapple, Ham, Cheese";
            pineapple.diameter = 10;
            pineapple.price = 5.99;
            Console.WriteLine(pineapple.toppings + " " + pineapple.diameter + " " + pineapple.price);

            Pizza pepperoni = new Pizza();
            pepperoni.toppings = "Pepperoni, Tomoato, Cheese";
            pepperoni.diameter = 13;
            pepperoni.price = 8.99;
            Console.WriteLine(pepperoni.toppings + " " + pepperoni.diameter + " " + pepperoni.price);

        }
    }
}
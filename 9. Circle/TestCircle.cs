using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    /// <summary>
    /// A class to test the circle class.
    /// </summary>
    class TestCircle
    {

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10);
            Console.WriteLine(c1.Radius + " " + Math.Round(c1.Diameter, 2) + " " + Math.Round(c1.Area, 2));

            Circle c2 = new Circle(20);
            Console.WriteLine(c2.Radius + " " + Math.Round(c2.Diameter, 2) + " " + Math.Round(c2.Area, 2));

            Circle c3 = new Circle(30);
            Console.WriteLine(c3.Radius + " " + Math.Round(c3.Diameter, 2) + " " + Math.Round(c3.Area, 2));

            c1.Radius = 100;
            Console.WriteLine(c1.Radius + " " + Math.Round(c1.Diameter, 2) + " " + Math.Round(c1.Area, 2));

            c2.Radius = 200;
            Console.WriteLine(c2.Radius + " " + Math.Round(c2.Diameter, 2) + " " + Math.Round(c2.Area, 2));

            c3.Radius = 300;
            Console.WriteLine(c3.Radius + " " + Math.Round(c3.Diameter, 2) + " " + Math.Round(c3.Area, 2));

        }
    }
}
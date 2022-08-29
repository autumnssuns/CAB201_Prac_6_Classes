using System;
using System.Collections.Generic;
using System.Text;

namespace Number
{

    /// <summary>
    /// A class that teststhe number class.
    /// </summary>
    class TestNumber
    {

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            MyNumber n = new MyNumber(2);
            Console.WriteLine(n.Number + " " + n.Square + " " + n.Cube);
            n.Number = 3;
            Console.WriteLine(n.Number + " " + n.Square + " " + n.Cube);
        }
    }
}
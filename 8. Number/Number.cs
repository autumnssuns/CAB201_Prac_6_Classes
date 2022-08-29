using System;

namespace Number
{
    /// <summary>
    /// A class the deomstrates a number.
    /// </summary>
    class MyNumber
    {
        /// <summary>
        /// The number.
        /// </summary>
        private double number;

        /// <summary>
        /// The square of the number.
        /// </summary>
        private double square;

        /// <summary>
        /// The cube of the number.
        /// </summary>
        private double cube;

        /// <summary>
        /// The number.
        /// </summary>
        public double Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                square = value * value;
                cube = value * value * value;
            }
        }

        /// <summary>
        /// The sqaure of the number.
        /// </summary>
        public double Square
        {
            get
            {
                return square;
            }
        }

        /// <summary>
        /// The cube of the number.
        /// </summary>
        public double Cube
        {
            get
            {
                return cube;
            }
        }


        /// <summary>
        /// A model of a number.
        /// </summary>
        /// <param name="number">The number.</param>
        public MyNumber(double number)
        {
            this.number = number;
            square = number * number;
            cube = number * number * number;
        }

    }
}
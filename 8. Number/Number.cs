using System;

namespace Number
{
    /// <summary>
    /// A class the demonstrates a number.
    /// </summary>
    class MyNumber
    {
        private int number;


        public MyNumber(int number)
        {
            this.number = number;
        }

        public int Number { get
            {
                return number;
            }
        }

        public int Square
        {
            get
            {
                return number * number;
            }
        }

        public int Cube
        {
            get
            {
                return Square * number;
            }
        }
    }
}

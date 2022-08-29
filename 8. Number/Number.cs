using System;

namespace Number
{
    /// <summary>
    /// A class the demonstrates a number.
    /// </summary>
    class MyNumber
    {
        public int myNumber { get; set; }

        public int Square
        {
            get { return myNumber * myNumber; }
        }

        public int Cube
        {
            get { return Square * myNumber; }
        }

        public MyNumber(int myNumber)
        {
            this.myNumber = myNumber;
        }
    }
}

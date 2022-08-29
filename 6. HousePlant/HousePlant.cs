using System;

namespace HousePlant
{
    /// <summary>
    /// Models a house plant.
    /// </summary>
    class HousePlant
    {
        public string name { get; }

        double price;
        public double Price { 
            get
            {
                price++;
                return price;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid price");
                } else
                {
                    price = value;
                }
            }
        }
        public bool isFed;

        public HousePlant(string name, double price, bool isFed)
        {
            this.name = name;
            this.price = price;
            this.isFed = isFed;
        }
    }
}

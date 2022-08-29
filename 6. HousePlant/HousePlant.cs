using System;

namespace HousePlant
{
    /// <summary>
    /// Models a house plant.
    /// </summary>
    class HousePlant
    {
        public string plantName { get; private set; }
        double plantPrice;
        public double PlantPrice
        {
            get 
            {
                plantPrice++;
                return plantPrice; 
            }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine($"Invalid input {value}");
                    plantPrice = 0;
                } else
                {
                    plantPrice = value;
                }
            }
        }
        public bool isFed { get; set; }

        public HousePlant(string plantName, double plantPrice, bool isFed)
        {
            this.plantName = plantName;
            this.plantPrice = plantPrice;
            this.isFed = isFed;
        }

        public void AddTag(string tag)
        {
            plantName = plantName + " " + tag;
        }
    }
}

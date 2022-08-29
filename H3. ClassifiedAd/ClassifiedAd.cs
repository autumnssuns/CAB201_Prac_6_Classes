
using System;

namespace ClassifiedAd
{
    /// <summary>
    /// A class that models a classified advertisement
    /// </summary>
    class ClassifiedAd
    {

        /// <summary>
        /// The classified advertisement's category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The classified advertisement’s number of words.
        /// </summary>
        public int NumberOfWords;

        /// <summary>
        /// The classified advertisement’s number of words.
        /// </summary>
        private int numberOfWords
        {
            get
            {
                return numberOfWords;
            }
            set
            {
                numberOfWords = value;
                Price = numberOfWords * RATE;
            }
        }

        /// <summary>
        /// The classified advertisement’s price.
        /// </summary>
        public int Price { get; private set; }

        /// <summary>
        /// The classified advertisement’s rate.
        /// </summary>
        const int RATE = 11;

        /// <summary>
        /// The classifed advertisement's model.
        /// </summary>
        /// <param name="category">The classifed advertisement's category.</param>
        /// <param name="numberOfWords">The classifed adverisement's number of words.</param>
        public ClassifiedAd(string category, int numberOfWords)
        {
            Category = category;
            NumberOfWords = numberOfWords;

        }

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            ClassifiedAd ad = new ClassifiedAd("Used Car", 100);
            Console.WriteLine(ad.Category + " " + ad.NumberOfWords + " " + ad.Price);
            ad.Category = "House";
            ad.NumberOfWords = 100000;
            Console.WriteLine(ad.Category + " " + ad.NumberOfWords + " " + ad.Price);
        }
    }
}

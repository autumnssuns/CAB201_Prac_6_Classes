using System;

namespace SalesTransaction
{
    /// <summary>
    /// A  class that models a sales transaction
    /// </summary>
    class SalesTransaction
    {
        /// <summary>
        /// The sale person's name.
        /// </summary>
        string salesPersonName;

        /// <summary>
        /// The sale amount.
        /// </summary>
        double salesAmount;

        /// <summary>
        /// The overall comission
        /// </summary>
        double commission;

        /// <summary>
        /// The comission rate.
        /// </summary>
        double commissionRate;

        /// <summary>
        /// Creates the model of a sales transaction.
        /// </summary>
        /// <param name="mySalespersonName">The sale person's name.</param>
        /// <param name="mySalesAmount">The sale amount.</param>
        /// <param name="myCommissionRate">The comission rate.</param>
        public SalesTransaction(string mySalespersonName, double mySalesAmount, double myCommissionRate)
        {
            salesPersonName = mySalespersonName;
            salesAmount = mySalesAmount;
            commissionRate = myCommissionRate;
            commission = commissionRate * salesAmount;
        }

        /// <summary>
        /// Creates the model of a sales transaction.
        /// </summary>
        /// <param name="mySalespersonName">The sale person's name.</param>
        /// <param name="mySalesAmount">The sale amount.</param>
        public SalesTransaction(string mySalespersonName, double mySalesAmount)
        {
            salesPersonName = mySalespersonName;
            salesAmount = mySalesAmount;
            commissionRate = 0;
            commission = 0;
        }


        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            SalesTransaction mike = new SalesTransaction("Mike", 200, 0.1);
            Console.WriteLine(mike.salesPersonName + " " + mike.salesAmount + " " + mike.commissionRate + " " + mike.commission);

            SalesTransaction mark = new SalesTransaction("Mark", 100);
            Console.WriteLine(mark.salesPersonName + " " + mark.salesAmount + " " + mark.commissionRate + " " + mark.commission);
        }
    }
}

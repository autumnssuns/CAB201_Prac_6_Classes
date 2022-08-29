using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    internal class TestNumber
    {
        MyNumber myNumber { get; set; }

        TestNumber(int number)
        {
            myNumber = new MyNumber(number);
        }

        static void Main(string[] args)
        {
            TestNumber tester = new TestNumber(48);
            Console.WriteLine(tester.myNumber.Square);
            tester.myNumber = new MyNumber(36);
            Console.WriteLine(tester.myNumber.Square);
        }
    }
}

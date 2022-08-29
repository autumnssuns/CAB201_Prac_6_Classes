using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    internal class TestNumber
    {
        static void Main(string[] args)
        {
            MyNumber number = new MyNumber(41);
            Console.WriteLine($"{number.Number} has square {number.Square} and has cube {number.Cube}");
        }
    }
}

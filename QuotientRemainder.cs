using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientRemainder
    {
        static void QuoRemain()
        {
            int dividend = 40, divisior = 2;
            int quotient = dividend / divisior;
            int remainder = dividend % divisior;
            Console.WriteLine("\n Dividend {0} Divisor {1}", dividend, divisior);
            Console.WriteLine("\n Quotient = " + quotient);
            Console.WriteLine("\n Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}

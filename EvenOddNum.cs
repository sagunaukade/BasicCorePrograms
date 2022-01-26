using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenOddNum
    {
       static void EvenOdd()
        {
            int num, rem;
            Console.WriteLine("\n Check number is even or odd ");
            Console.WriteLine("\n Enter Number ");
            num = Convert.ToInt32(Console.ReadLine());
            rem = num / 2;
            if(rem==0)
            {
                Console.WriteLine("\n {0} is even number " + num);

            }
            else
            {
                Console.WriteLine("\n {0} is odd number " + num);
            }
        }
    }
}

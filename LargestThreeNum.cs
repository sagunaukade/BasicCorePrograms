using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestThreeNum
    {
        static void LargestAmongThreeNUm()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third Number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("First number is greatest among three");
                }
                else
                {
                    Console.WriteLine("Third number is greatest among three");

                }

            }
            else if (num2 > num3)
            {
                Console.WriteLine("Second number is greatest among three");

            }
            else
            {
                Console.WriteLine("Third number is greatest among three");

            }
        }
    }
}

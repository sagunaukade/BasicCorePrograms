using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapTwoNumbers
    {
        static void SwaptwoNum()
        {
            int num1, num2, temp;
            Console.WriteLine("\n Enter the first number ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the Second number ");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("\n After Swapping");
            Console.WriteLine("\n First Num " + num1);
            Console.WriteLine("\n Second Num " + num2);
            Console.ReadLine();
        }
    }
}

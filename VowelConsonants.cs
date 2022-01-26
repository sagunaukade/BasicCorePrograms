using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelConsonants
    {
        static void VowelConso()
        {
            char ch;
            bool lower_vowel, upper_vowel;
            Console.WriteLine("Enter character\n ");
            ch = Convert.ToChar(Console.ReadLine());
            lower_vowel = (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
            upper_vowel = (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U');
            if(lower_vowel || upper_vowel)
            {
                Console.WriteLine("Character is vowel ");
            }
            else
            {
                Console.WriteLine("Character is consonant ");

            }
        }
    }
}

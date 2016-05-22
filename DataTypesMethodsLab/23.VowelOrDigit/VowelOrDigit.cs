using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string vowels = "AEIOUYaeiouy";
            string digits = "0123456789";

            if (vowels.Contains(input))
            {
                Console.WriteLine("vowel");
            }

            else if (digits.Contains(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}

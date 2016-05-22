using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            PrintReversedNumbers(number);
        }

        private static void PrintReversedNumbers(string number)
        {
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Console.WriteLine(String.Join(" ", input.Reverse()));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter1 = Console.ReadLine();
            string letter2 = Console.ReadLine();
            string letter3 = Console.ReadLine();


            string result = letter1 + letter2 + letter3;
            char[] reversedResult = result.ToCharArray();
            Array.Reverse(reversedResult);

            foreach (var item in reversedResult)
            {
                Console.Write(item);
            }
        }
    }
}

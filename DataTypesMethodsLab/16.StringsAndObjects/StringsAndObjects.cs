using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string inputString1 = Console.ReadLine();
            string inputString2 = Console.ReadLine();

            object objectFile = inputString1 + " " + inputString2;

            string resultingString =(string) objectFile;

            Console.WriteLine(resultingString);
        }
    }
}

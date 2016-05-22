using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int value = Convert.ToInt32(n, 16);

            Console.WriteLine(value);
        }
    }
}

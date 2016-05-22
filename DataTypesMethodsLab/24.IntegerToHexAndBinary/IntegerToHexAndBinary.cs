﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string valueInHex = input.ToString("X");
            string valueInBinary = Convert.ToString(input, 2);

            Console.WriteLine($"{valueInHex}\r\n{valueInBinary}");
        }
    }
}

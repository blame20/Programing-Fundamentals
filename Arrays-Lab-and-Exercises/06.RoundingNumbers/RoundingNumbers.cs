﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => {Math.Round(arr[i], 0, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

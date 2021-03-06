﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumMinMaxFirstLastAverage
{
    class SumMinMaxFirstLastAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Fist = {nums.First()}");
            Console.WriteLine($"Last = {nums.Last()}");
            Console.WriteLine($"Avarage = {(double) nums.Average()}");
        }
    }
}

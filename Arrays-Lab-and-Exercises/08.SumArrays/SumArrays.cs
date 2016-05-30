using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = Math.Max(arr1.Length, arr2.Length);
            int[] sum = new int[result];

            for (int i = 0; i < result; i++)
            {
                sum[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}

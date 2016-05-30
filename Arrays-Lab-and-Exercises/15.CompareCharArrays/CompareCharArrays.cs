using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] <= arr2[i] && arr1.Length <= arr2.Length)
                {
                    Console.WriteLine(arr1);
                    Console.WriteLine(arr2);
                    return;
                }
                if (arr1[i] > arr2[i] || arr1.Length > arr2.Length)
                {
                    Console.WriteLine(arr2);
                    Console.WriteLine(arr1);
                    return;
                }
                if (arr1[i] == arr2[i] && arr1.Length == arr2.Length)
                {
                    Console.WriteLine(arr1);
                    Console.WriteLine(arr2);
                    return;
                }
            }
            if (arr1.Length > arr2.Length || arr1.Length == arr2.Length)
            {
                Console.WriteLine(arr1);
                Console.WriteLine(arr2);
                return;
            }
            else
            {
                Console.WriteLine(arr2);
                Console.WriteLine(arr1);
                return;
            }         
        }
    }
}

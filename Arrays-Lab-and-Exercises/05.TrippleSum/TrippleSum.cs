using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TrippleSum
{
    class TrippleSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool finder = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");
                        finder = true;
                    }
                }
            }
            if (!finder)
            {
                Console.WriteLine("No");
            }
        }
    }
}

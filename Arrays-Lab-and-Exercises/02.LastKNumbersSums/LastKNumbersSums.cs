using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            decimal[] arr = new decimal[n];
            arr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                arr[i] = SumNums(arr, i - k, i - 1);
            }
            Console.WriteLine(String.Join(" ", arr));
        }

        private static decimal SumNums(decimal[] arr, int v1, int v2)
        {
            decimal sum = 0;
            for (int i = v1; i <= v2; i++)
            {
                if (i >= 0) sum += arr[i];
            }
            return sum;
        }
    }
}

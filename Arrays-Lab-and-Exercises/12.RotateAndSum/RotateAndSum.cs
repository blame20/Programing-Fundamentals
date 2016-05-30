using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[n.Length];

            for (int i = 0; i < k; i++)
            {
                int lastElement = n[n.Length - 1];

                for (int j = n.Length - 1; j > 0; j--)
                {
                    n[j] = n[j - 1];
                }
                n[0] = lastElement;
                //Console.WriteLine(string.Join(" ", n));

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] = sum[j] + n[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}

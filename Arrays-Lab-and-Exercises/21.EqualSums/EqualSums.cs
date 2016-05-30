using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _21.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            BigInteger[] array = Console.ReadLine()
                   .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(BigInteger.Parse)
                   .ToArray();

            int index = -1;

            if (array.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 1; i < array.Length; i++)
                {
                    BigInteger leftSum = 0;

                    for (int left = i - 1; left >= 0; left--)
                    {
                        leftSum += array[left];
                    }

                    BigInteger rightSum = 0;

                    for (int right = i + 1; right < array.Length; right++)
                    {
                        rightSum += array[right];
                    }
                    
                    if (leftSum == rightSum)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    Console.WriteLine(index);
                }
                if (index == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}

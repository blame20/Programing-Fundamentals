using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');
            int result = 0;
            int lowest = 0;
            int counter = 0;

            if (arr1.Length > arr2.Length)
            {
                lowest = arr2.Length;
            }
            else
            {
                lowest = arr1.Length;
            }

            for (int i = 0; i < lowest; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    result++;
                }
            }
            for (int i = arr1.Length - 1, g = arr2.Length - 1; i >= 0 && g >= 0; i--, g--)
            {
                if (arr1[i] == arr2[g])
                {
                    counter++;
                }
            }
            if (counter > result)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine(result);
            }
        }     
    }
}

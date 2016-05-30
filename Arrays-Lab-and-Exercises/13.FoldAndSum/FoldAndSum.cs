using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] leftArray = new int[k];
            int[] rightArray = new int[k];
            int[] middleArray = new int[k * 2];
            int[] upper = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                leftArray[i] = array[i];
            }

            leftArray = leftArray.Reverse().ToArray();
            //Console.WriteLine(string.Join(" ", leftArray));

            for (int i = 3 * k, j = 0; j < rightArray.Length; i++, j++)
            {
                rightArray[j] = array[i];
            }

            rightArray = rightArray.Reverse().ToArray();
            //Console.WriteLine(string.Join(" ", rightArray));

            for (int i = k, j = 0; j < middleArray.Length; i++, j++)
            {
                middleArray[j] = array[i];
            }
            //Console.WriteLine(string.Join(" ", middleArray));

            for (int i = 0; i < leftArray.Length; i++)
            {
                upper[i] = leftArray[i];
            }
            //Console.WriteLine(string.Join(" ", upper));
            for (int i = leftArray.Length, j = 0; j < rightArray.Length; i++, j++)
            {
                upper[i] = rightArray[j];
            }
            //Console.WriteLine(string.Join(" ", upper));

            for (int i = 0; i < upper.Length; i++)
            {
                Console.Write(upper[i] + middleArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.MaxSequenceEqualElements
{
    class MaxSequenceEqualElements
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int longestEqualSequence = 1;
            int currentSequence = 1;
            int currentNumber = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > longestEqualSequence)
                {
                    longestEqualSequence = currentSequence;
                    currentNumber = array[i];
                }
            }

            for (int i = 0; i < longestEqualSequence; i++)
            {
                Console.Write($"{currentNumber + " "}");
            }
            Console.WriteLine();
        }
    }
}

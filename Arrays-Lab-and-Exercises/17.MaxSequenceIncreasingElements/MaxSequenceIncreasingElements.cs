using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.MaxSequenceIncreasingElements
{
    class MaxSequenceIncreasingElements
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int sequencePosStart = 0;
            int currentPosCount = 1;
            int start = sequencePosStart;
            int count = currentPosCount;

            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] <= array[i + 1] - 1)
                {
                    sequencePosStart = (i + 1) - currentPosCount;
                    currentPosCount++;
                }
                else
                {
                    currentPosCount = 1;
                }
                if (currentPosCount > count)
                {
                    count = currentPosCount;
                    start = sequencePosStart;
                }
            }
            for (int i = start; i < start + count; i++)
            {
                Console.Write($"{array[i] + " "}");
            }
            Console.WriteLine();
        }
    }
}

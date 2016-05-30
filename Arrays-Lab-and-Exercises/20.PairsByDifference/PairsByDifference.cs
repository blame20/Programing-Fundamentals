using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] - array[j] == difference || array[j] - array[i] == difference)
                    {
                        counter++;
                    }
                } 
            }
            Console.WriteLine(counter);
        }
    }
}

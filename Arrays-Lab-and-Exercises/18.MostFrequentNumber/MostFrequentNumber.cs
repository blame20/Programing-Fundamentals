using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            decimal[] array = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            var result = array.GroupBy(n => n).OrderByDescending(n => n.Count()).ToArray();

            Console.WriteLine(result.First().Key);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.PrimesGivenRange
{
    class PrimesGivenRange
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(", ", FindPrimesInRange(n, n1)));
        }

        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {

            List<int> result = new List<int>();
            for (int i = startNum; i <= endNum; ++i)
            {
                if (isPrimeCheck(i))
                {
                    result.Add(i);
                }
            }
           return result;
        }
        private static bool isPrimeCheck(int n)
        {
            if (n == 0) return false;
            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}

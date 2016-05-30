using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int maxPrime = int.Parse(Console.ReadLine());
            var primeResult = primesFind(maxPrime);

            foreach (var prime in primeResult)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();
        }

        private static List<int> primesFind(int maxPrime)
        {
            var primes = new List<int>() { 2 };
            var squareRoot = Math.Sqrt(maxPrime);
            var remove = new BitArray(maxPrime + 1);

            for (int i = 3; i <= maxPrime; i+=2)
            {
                if (!remove[i])
                {
                    primes.Add(i);

                    if (i < squareRoot)
                    {
                        for (int j = i * i; j <= maxPrime; j+=2 * i)
                        {
                            remove[j] = true;
                        }
                    }
                }
            }
            return primes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string lettersInput = Console.ReadLine();
            int[] alphabetArray = new int[26];

            for (int i = 0; i < alphabetArray.Length; i++)
            {
                alphabetArray[i] = (char)('a' + i);
            }
            foreach (var letters in lettersInput)
            {
                for (int i = 0; i < alphabetArray.Length; i++)
                {
                    if (letters == alphabetArray[i])
                    {
                        Console.WriteLine($"{letters} -> {i}");
                    }
                }
            }
        }
    }
}

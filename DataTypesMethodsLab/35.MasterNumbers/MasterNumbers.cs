using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            //if (IsPalindrome && SumOfDigits && ContainsEvenDigit)
            //{

            //}
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (IsPalidrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
  
        }

        private static bool ContainsEvenDigit(int num)
        {
            string number = Convert.ToString(num);    
            foreach (var item in number)
            {
                if (int.Parse(item.ToString()) % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool SumOfDigits(int num)
        {
            char[] array = num.ToString().ToCharArray();
            int sum = 0;

            foreach (var item in array)
            {
                sum += int.Parse(item.ToString());
            }
            return sum % 7 == 0;
        }

        private static bool IsPalidrome (int num)
        {
            string number = Convert.ToString(num);

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

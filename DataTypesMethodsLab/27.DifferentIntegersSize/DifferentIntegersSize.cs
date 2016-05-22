using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();

            try
            {
                long longNumber = long.Parse(inputNumber);
                Console.WriteLine($"{inputNumber} can fit in:");
            }
            catch (Exception)
            {
                Console.WriteLine($"{inputNumber} can't fit in any type");
            }
            try
            {
                sbyte sByteNumber = sbyte.Parse(inputNumber);
                Console.WriteLine("* sbyte");
            }
            catch (OverflowException)
            {
            }
            try
            {
                byte byteNumber = byte.Parse(inputNumber);
                Console.WriteLine("* byte");
            }
            catch (OverflowException)
            {
            }
            try
            {
                short shortNumber = short.Parse(inputNumber);
                Console.WriteLine("* short");
            }
            catch (OverflowException)
            {
            }
            try
            {
                ushort ushortNumber = ushort.Parse(inputNumber);
                Console.WriteLine("* ushort");
            }
            catch (OverflowException)
            {
            }
            try
            {
                int intNumber = int.Parse(inputNumber);
                Console.WriteLine("* int");
            }
            catch (OverflowException)
            {
            }
            try
            {
                uint intNumber = uint.Parse(inputNumber);
                Console.WriteLine("* uint");
            }
            catch (OverflowException)
            {
            }
            try
            {
                long longNumber = long.Parse(inputNumber);
                Console.WriteLine("* long");
            }
            catch (OverflowException)
            {
       
            }
        }
    }
}

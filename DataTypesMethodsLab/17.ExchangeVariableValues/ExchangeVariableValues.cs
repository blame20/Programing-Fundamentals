using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;

            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");

            a = b;
            b = c;

            Console.WriteLine($"After:\r\na = {a}\r\nb = {c}");
        }
    }
}

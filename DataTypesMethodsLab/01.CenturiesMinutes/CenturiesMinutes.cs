using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CenturiesMinutes
{
    class CenturiesMinutes
    {
        static void Main(string[] args)
        {
            byte centuries = (byte)int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)Math.Round(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;

            Console.WriteLine(centuries);
            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
        }
    }
}

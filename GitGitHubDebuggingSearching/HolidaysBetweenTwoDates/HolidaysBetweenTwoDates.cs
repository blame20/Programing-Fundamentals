using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidaysBetweenTwoDates
{
    class HolidaysBetweenTwoDates
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact (Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture); // mistake 1
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture); // mistake 2

            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1)) // mistake 3
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) // mistake 4 
                {
                    holidaysCount++;
                }
            }
            Console.WriteLine(holidaysCount);
        }
    }
}

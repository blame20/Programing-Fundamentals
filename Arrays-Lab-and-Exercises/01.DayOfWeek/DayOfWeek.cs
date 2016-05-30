using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int choiceOfDay = int.Parse(Console.ReadLine());

            string[] arrayWithDayOfWeeks = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday",
                                                         "Friday", "Saturday", "Sunday"};

            if (choiceOfDay >= 1 && choiceOfDay <= 7)
            {
                Console.WriteLine($"{arrayWithDayOfWeeks[choiceOfDay - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}

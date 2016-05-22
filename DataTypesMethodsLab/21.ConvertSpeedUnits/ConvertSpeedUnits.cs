using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _21.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            hours = hours * 60 * 60;
            minutes = minutes * 60;
            float totalSeconds = hours + minutes + seconds;
            float metersPerKm = meters / 1000;
            float totalHours = totalSeconds / 60 / 60;
            float KmPerMiles = meters / 1609f;
            
            Console.WriteLine($"{meters / totalSeconds}");
            Console.WriteLine($"{metersPerKm / totalHours}");
            Console.WriteLine($"{KmPerMiles / totalHours}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong id = ulong.Parse(Console.ReadLine());
            uint uniqueNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstname}\r\nLast name: {lastName}\r\nAge: {age}\r\nGender: {gender}\r\nPersonal ID: {id}\r\nUnique Employee number: {uniqueNumber}");
        }
    }
}

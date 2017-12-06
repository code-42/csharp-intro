using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

namespace Exercise3_Section_8_Lecture_67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a time value in the 24-hour time format (e.g. 19:00): ");
            var input = Console.ReadLine();
     
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            if (input.IndexOf(':') == -1)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var timeArr = input.Split(':');
            var hour = Convert.ToByte(timeArr[0]);
            var min = Convert.ToByte(timeArr[1]);
            if (hour > 24 || (hour < 24 && min > 59))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            Console.WriteLine("Ok");
            return;
        }
    }
}

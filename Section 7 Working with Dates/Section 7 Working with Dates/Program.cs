using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_7_Working_with_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Methods
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add and Subtract
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString()
            Console.WriteLine("ToString " + timeSpan.ToString());

            // Parse()
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

            // Quiz
            var dateTime = new DateTime(2015, 1, 1);
            dateTime.AddYears(1);
            Console.WriteLine(dateTime.Year);

            Console.WriteLine(DateTime.Now.Year);
        }
    }
}

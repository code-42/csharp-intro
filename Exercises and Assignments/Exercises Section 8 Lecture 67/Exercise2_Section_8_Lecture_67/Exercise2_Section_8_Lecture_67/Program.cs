using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Section_8_Lecture_67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen (ex. 5-6-7-8): ");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                var dupItems = numbers.Contains(Convert.ToInt32(number));
                if (dupItems)
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
                numbers.Add(Convert.ToInt32(number));
            }
        }
    }
}

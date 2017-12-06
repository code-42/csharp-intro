using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Section_8_Lecture_67
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers;
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine().Split('-');
            var numList = new List<int>();

            foreach (var number in input)
            {
                numList.Add(Convert.ToInt32(number));
            }
            
            numList.Sort();
            
            Console.WriteLine();
            for (var i = 0; i < numList.Count - 1; i++)
            {
                if (numList[i + 1] != numList[i] + 1)
                {
                    Console.WriteLine("Not Consecutive");
                    break;
                }
                else
                {
                    if(i == numList.Count - 2)
                        Console.WriteLine("Consecutive");
                }
                    
            }
        }
    }
}

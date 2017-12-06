using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

namespace Exercise5_Section_8_Lecture_67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an English word: ");
            var input = Console.ReadLine().ToLower();

            string[] vowels = { "a", "e", "o", "u", "i" };
            char[] charArray = input.ToCharArray();
            int count = 0;
            foreach (var c in charArray)
            {
                foreach (var v in vowels)
                {
                    if (Convert.ToChar(v) == Convert.ToChar(c))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}

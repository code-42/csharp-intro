using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". If the user doesn't supply any words, display "Error".

namespace Exercise4_Section_8_Lecture_67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words separated by a space: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }
            
            var inList = new List<string>();
            foreach (var ch in input.Split(' '))
            {
                inList.Add(ch.ToLower());
            }

            var variableName = "";
            foreach (var word in inList)
            {
                variableName += (word.Substring(0, 1).ToUpper() + "" + word.Substring(1));
            }
            Console.WriteLine();
            Console.WriteLine(variableName);
        }
    }
}

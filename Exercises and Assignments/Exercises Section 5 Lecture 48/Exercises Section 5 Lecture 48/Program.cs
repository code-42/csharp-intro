using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Section_5_Lecture_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
        }

        public static void Exercise1()
        //   1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
        {
            int count = 0;
            for (var i = 1; i< 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        // 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
        private static void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (type 'ok' to exit): ");
                var input = Console.ReadLine();
                
                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine(sum);
        }

        // 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        private static void Exercise3()
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var prevNum = 1;
            if (number == 0)
                prevNum = 1;

            for (var i = 1; i <= number; i++)
                prevNum *= i;

            Console.WriteLine("{0}! = {1}", number, prevNum);
        }

        // 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        private static void Exercise4()
        {
            var random = new Random().Next(1, 10);
            Console.WriteLine(random);

            for (var i = 0; i < 4; i++)
            {
                Console.Write("guess the number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (number == random)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }
            Console.WriteLine("You lost");
        }


        // 5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        private static void Exercise5()
        {
            Console.WriteLine("Enter a series of numbers separated by comma: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);
            for (var i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) > max)
                {
                    max = Convert.ToInt32(numbers[i]);
                }
            }
            Console.WriteLine(max);
        }
    }
}

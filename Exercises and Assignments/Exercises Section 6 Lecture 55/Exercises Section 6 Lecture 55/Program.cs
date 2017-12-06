using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Section_6_Lecture_55
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
        }


        /* 
         * 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
    
           * If no one likes your post, it doesn't display anything.
           * If only one person likes your post, it displays: [Friend's Name] likes your post.
           * If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
           * If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
           
           Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        */
        public static void Exercise1()
        {
            // Create a new List of strings
            var friends = new List<string>();

            while (true)
            {
                // Ask the user to enter different names
                Console.WriteLine("Enter your friends names (press Enter key to finish): ");
                var input = Console.ReadLine();

                // pressing Enter(without supplying a name) stops the input 
                if (String.IsNullOrWhiteSpace(input))
                    break;
                friends.Add(input);
            }

            var numFriends = friends.Count;

            switch (numFriends)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(friends[0] + "likes your post.");
                    break;
                case 2:
                    Console.WriteLine(friends[0] + " and " + friends[1] + " like your post.");
                    break;
                case 3:
                    Console.WriteLine(friends[0] + ", " + friends[1] + " and " + (numFriends - 2) + " other likes your post.");
                    break;
                default:
                    Console.WriteLine(friends[0] + ", " + friends[1] + " and " + (numFriends - 2) + " others like your post.");
                    break;
            }
        }


        /*
         2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
         */
        public static void Exercise2()
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            //var revName = new string(name.ToCharArray().Reverse().ToArray());

            // Refactor to use array
            var arrLen = name.Length;
            var array = new char[arrLen];
            for (var i = 0; i < arrLen; i++)
            {
                array[i] = name[arrLen - 1 - i];
            }

            var revName = new string(array);
            Console.WriteLine(revName);
        }


        // 3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        public static void Exercise3()
        {
            // Initialize array of size 5
            int[] numArr = new int[5];

            // Prompt user for input
            Console.WriteLine("Enter 5 numbers: ");

            // Loop through the array and assign the input to next element
            for (var i = 0; i < 5; i++)
            {
                // Read input from command line
                var input = int.Parse(Console.ReadLine());

                // Display error message if number has been previously entered
                if (numArr.Contains(input))
                {
                    Console.WriteLine("Please enter unique numbers.");
                    // Manually resize the array to account for incorrect iput
                    Array.Resize(ref numArr, numArr.Length - 1);
                    Array.Resize(ref numArr, numArr.Length + 1);
                    i--;
                    continue;
                }

                // Prompt the user for another number
                Console.WriteLine("Enter another number: ");

                // Assign input into next array element
                numArr[i] = input;
            }

            // Sort the array
            Array.Sort(numArr);

            // Write a blank line 
            Console.WriteLine();

            // Loop through the sorted array and display the numbers
            foreach (var num in numArr)
            {
                Console.WriteLine(num);
            }
        }


        // 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        public static void Exercise4()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number (or type Quit to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit" || String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("input was " + input);
                    break;
                }

                var number = int.Parse(input);
                numbers.Add(number);
            }

            var uniqueNumbers = numbers.Distinct();
            foreach (var number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }

        }

        // 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
        public static void Exercise5()
        {
            string[] numbers;
            while (true)
            {
                Console.WriteLine("Enter a list of numbers separated by commas: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    numbers = input.Split(',');
                    if (numbers.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid List, please re-try");
            }

            var numList = new List<int>();
            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                numList.Add(number);
            }

            numList.Sort();
            var shortList = numList.Take(3);
            foreach (var numbr in shortList)
            {
                Console.WriteLine(numbr);
            }
        }
    }
}

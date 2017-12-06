using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Section_4_Non_Primitive_Types
{
    public class Person
    {
        public int Age;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Lecture 37 Reference Types and Value Types
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person(){Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}

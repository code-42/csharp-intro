using System;

namespace Section_4_Non_Primitive_Types
{
    public class OldPerson
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
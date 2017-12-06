using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_5_Control_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = ((char)('a' + random.Next(0, 26)));
            Console.WriteLine();

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}

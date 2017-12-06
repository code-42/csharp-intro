using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_8_Working_with_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            // Section 8 Lecture 64
            var sentence = "This is a really very very long sentence.";
            const int maxLength = 20;

            if (sentence.Length < maxLength)
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                var summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);
            }
        }

        static string SummarizeText(string text)
        {
            const int maxLength = 20;

            if(sentence.Length < maxLength)
                Console.WriteLine(sentence);
        }
    }
}

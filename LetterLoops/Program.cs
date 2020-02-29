using System;
using System.Text;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of letters with no spaces:");
            var userInput = Console.ReadLine();
            var counter = 0;
            StringBuilder build = new StringBuilder();

            
            foreach (var letter in userInput)
            {
                build.Append(letter.ToString().ToUpper());
                if (counter > 0)
                {
                    for (int i = 0; i < counter; i++)
                    {
                        build.Append(letter.ToString().ToLower());
                    }
                }
                counter += 1;

                if (counter < userInput.Length)
                {
                    build.Append("-");
                }
            }

            var finalString = build.ToString();

            Console.WriteLine(finalString);
            Console.ReadKey();
        }
    }
}

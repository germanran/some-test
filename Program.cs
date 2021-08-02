using System;
using System.Collections.Generic;
using udemyCourse;

namespace udemyCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            string input;
            string resultMessage = "";
            while (true)
            {
                Console.WriteLine("Please enter names");
                input = Console.ReadLine();

                if (input.Length > 0)
                {
                    names.Add(input);
                }
                else
                {
                    break;
                }

      
            }
            

            switch (names.Count)
            {
                case 0:
                    break;
                case 1:
                    resultMessage = string.Format("{0} likes your post", names[0]);
                    break;
                case 2:
                    resultMessage = string.Format("{0} and {1} likes your post", names[0], names[1]);
                    break;
                default:
                    resultMessage = string.Format("{0}, {1} and others like your post", names[0], names[1]);
                    break;
            }
            Console.WriteLine(resultMessage);
        }
    }
}


using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> systems = new List<string>();
            Dictionary<string, string> list = new Dictionary<string, string>();

            Console.WriteLine("do you want to add a console? (Y/N)");
            string answer = Console.ReadLine().ToLower();
            if(answer == "y")
            {
                systems.Add(Console.ReadLine());
                // write to a file
            } else if(answer == "n")
            {
                Console.WriteLine("would you like to add a game? (Y/N)");
                answer = Console.ReadLine().ToLower();
                if(answer == "y")
                {
                    Console.WriteLine("what system is it on?");
                    answer = Console.ReadLine().ToLower();

                    Console.WriteLine("what is the game you're inputting?");
                    list[answer] = Console.ReadLine();

                    // write to a file
                }
            }

        }
    }
}

using love_bot.classes;
using System;

namespace love_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("it's a wonderful thing to be able to tell someone you love them.");
            Console.ReadLine();
            Console.Write("what language do you want to share your affection in?\n(each result is romanized, and in the most general form for each langauge): ");
            string desiredLanguage = languages.ChangeLanguage();
            if (desiredLanguage == null || desiredLanguage == "")
            {
                Console.Write("please try again and enter a language.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"to tell someone you love them in {desiredLanguage}, you say \"{languages.Love}.\"");
                Console.WriteLine($"{languages.Love}!");
                Console.WriteLine($"{languages.Love}!");
                Console.Write($"{languages.Love}!");
                Console.ReadLine();
            }
            Console.Write("always choose to love, for if we love, we survive.");
            Console.ReadLine();

        }
    }
}

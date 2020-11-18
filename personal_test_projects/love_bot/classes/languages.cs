using System;
using System.Collections.Generic;
using System.Text;

namespace love_bot.classes
{
    class languages
    {
        public static string Love { get; set; }

        public static string DesiredLanguage { get; set; }

        public static string ChangeLanguage()
        {
            DesiredLanguage = (Console.ReadLine().ToLower());
            if (DesiredLanguage.Contains("english"))
            {
                Love = "i love you";
            }
            else if (DesiredLanguage.Contains("french"))
            {
                Love = "je t'aime";
            }
            else if (DesiredLanguage.Contains("spanish"))
            {
                Love = "te quiero";
            }
            else if (DesiredLanguage.Contains("chinese"))
            {
                Console.Write("did you want that in mandarin or cantonese? ");
                if (Console.ReadLine().Contains("mandarin"))
                {
                    Love = "wo ai ni";
                }
                else
                {
                    Love = "ngo oiy ney a";
                }
            }
            else if (DesiredLanguage.Contains("arabic"))
            {
                Console.Write("did you want to say it in the formal variation or the close variation? ");
                if (Console.ReadLine().Contains("formal"))
                {
                    Love = "ana uhebak";
                } else
                {
                    Love = "ana ahebak";
                }
            }
            else if (DesiredLanguage.Contains("italian"))
            {
                Love = "ti amo";
            } else if (DesiredLanguage.Contains("german"))
            {
                Love = "ich liebe dich";
            } else if (DesiredLanguage.Contains("maori"))
            {
                Love = "ka nui taku aroha ki a koe";
            }
            return DesiredLanguage;
        }
    }
}

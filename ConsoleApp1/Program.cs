using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> bengaliMap = new Dictionary<string, string>()
        {
            {"a", "\u09BE"}, {"b", "\u09AC"}, {"c", "\u099A"}, {"d", "\u09A1"}, {"e", "\u09C7"},
            {"f", "\u09AB"}, {"g", "\u0997"}, {"h", "\u09B9"}, {"i", "\u09BF"}, {"j", "\u099C"},
            {"k", "\u0995"}, {"l", "\u09B2"}, {"m", "\u09AE"}, {"n", "\u09A8"}, {"o", "\u09CB"},
            {"p", "\u09AA"}, {"q", "\u0994"}, {"r", "\u09B0"}, {"s", "\u09B8"}, {"t", "\u09A4"},
            {"u", "\u09C1"}, {"v", "\u09AD"}, {"w", "\u09AC"}, {"x", "\u0995\u09CD\u09B8"}, {"y", "\u09AF"},
            {"z", "\u099C\u09CD\u09AF"}
        };

        Console.WriteLine("Enter a word in English to get the Bengali text. Enter 'exit' to stop.");
        
        while (true)
        {
            string input = Console.ReadLine().ToLower();
            if (input == "exit")
                break;

            string bengaliWord = ConvertToBengali(input, bengaliMap);
            Console.WriteLine("Bengali: " + bengaliWord);
        }
    }

    static string ConvertToBengali(string word, Dictionary<string, string> bengaliMap)
    {
        string bengaliWord = "";

        foreach (char c in word)
        {
            string character = c.ToString();

            if (bengaliMap.ContainsKey(character))
            {
                bengaliWord += bengaliMap[character];
            }
            else
            {
                bengaliWord += c;
            }
        }

        return bengaliWord;
    }
}

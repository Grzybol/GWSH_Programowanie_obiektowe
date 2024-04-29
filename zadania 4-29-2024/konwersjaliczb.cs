using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static readonly Dictionary<string, int> numbers = new Dictionary<string, int>
    {
        {"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4}, {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9},
        {"ten", 10}, {"eleven", 11}, {"twelve", 12}, {"thirteen", 13}, {"fourteen", 14}, {"fifteen", 15}, {"sixteen", 16}, {"seventeen", 17}, {"eighteen", 18}, {"nineteen", 19},
        {"twenty", 20}, {"thirty", 30}, {"forty", 40}, {"fifty", 50}, {"sixty", 60}, {"seventy", 70}, {"eighty", 80}, {"ninety", 90},
        {"hundred", 100}, {"thousand", 1000}, {"million", 1000000}
    };

    public static int WordsToNumber(string input)
    {
        int total = 0;
        int current = 0;

        string[] tokens = input.ToLower().Replace("and", "").Split(new char[] {' ', '-'}, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (string word in tokens)
        {
            if (numbers[word] >= 1000)
            {
                current *= numbers[word];
                total += current;
                current = 0;
            }
            else if (numbers[word] >= 100)
            {
                current *= numbers[word];
            }
            else
            {
                current += numbers[word];
            }
        }

        return total + current;
    }

    public static void Main()
    {
        Console.WriteLine(WordsToNumber("one"));  // Output: 1
        Console.WriteLine(WordsToNumber("twenty"));  // Output: 20
        Console.WriteLine(WordsToNumber("two hundred forty-six"));  // Output: 246
        Console.WriteLine(WordsToNumber("seven hundred eighty-three thousand nine hundred and nineteen"));  // Output: 783919
    }
}

using System;
using System.Collections.Generic;

public class Program
{
    private static readonly Dictionary<char, int> romanValues = new Dictionary<char, int>
    {
        {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
        {'C', 100}, {'D', 500}, {'M', 1000}
    };

    public static int RomanToInteger(string roman)
    {
        int sum = 0;
        int lastValue = 0;

        for (int i = roman.Length - 1; i >= 0; i--)
        {
            int value = romanValues[roman[i]];

            if (value >= lastValue)
            {
                sum += value;
            }
            else
            {
                sum -= value;
            }

            lastValue = value;
        }

        return sum;
    }

    public static void Main()
    {
        Console.WriteLine(RomanToInteger("MDCLXVI"));   // Output: 1666
        Console.WriteLine(RomanToInteger("MMVIII"));    // Output: 2008
        Console.WriteLine(RomanToInteger("MCMXC"));     // Output: 1990
    }
}

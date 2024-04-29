using System;
using System.Collections.Generic;

public class Program
{
    public static int FindNextSpecialNumber(int number)
    {
        for (int i = number + 1; ; i++)
        {
            if (i % 2 != 0 && i % 3 == 0 && AreDigitsUnique(i))
            {
                return i;
            }
        }
    }

    private static bool AreDigitsUnique(int number)
    {
        var digits = new HashSet<int>();
        while (number > 0)
        {
            int digit = number % 10;
            if (!digits.Add(digit))
            {
                return false;
            }
            number /= 10;
        }
        return true;
    }

    public static void Main()
    {
        Console.WriteLine(FindNextSpecialNumber(10));  // Output: 15
        Console.WriteLine(FindNextSpecialNumber(24));  // Output: 27
        Console.WriteLine(FindNextSpecialNumber(123)); // Output: 135
    }
}

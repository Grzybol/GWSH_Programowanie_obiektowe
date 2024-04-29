using System;
using System.Text.RegularExpressions;

public class Program
{
    public static string ExtractPhoneNumber(string input)
    {
        var match = Regex.Match(input, @"0\d{10}");

        if (match.Success && match.Value.Length == 11)
        {
            return match.Value;
        }
        else
        {
            return "To nie jest numer telefonu";
        }
    }

    public static void Main()
    {
        Console.WriteLine(ExtractPhoneNumber("efRFS:)0207ERGQREG88349F82!")); // Output: 02078834982
        Console.WriteLine(ExtractPhoneNumber("Hello World!")); // Output: To nie jest numer telefonu
        Console.WriteLine(ExtractPhoneNumber("Call me at 01234567890 tomorrow.")); // Output: 01234567890
    }
}

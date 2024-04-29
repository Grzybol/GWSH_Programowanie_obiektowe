using System;
using System.Text.RegularExpressions;

public class Program
{
    public static string RemoveVowels(string input)
    {
        return Regex.Replace(input, "[aeiouAEIOU]", "");
    }

    public static void Main()
    {
        string comment = "Ta strona jest dla looserów";
        string result = RemoveVowels(comment);
        Console.WriteLine(result);
    }
}
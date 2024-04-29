using System;

public class Program
{
    public static bool IsSumOfPowersOfDigits(int number)
    {
        string digits = number.ToString();
        int length = digits.Length;
        int sum = 0;

        foreach (char digit in digits)
        {
            int digitValue = digit - '0';
            sum += (int)Math.Pow(digitValue, length);
        }

        return sum == number;
    }

    public static void Main()
    {
        Console.WriteLine(IsSumOfPowersOfDigits(153));  // Output: True
        Console.WriteLine(IsSumOfPowersOfDigits(1652)); // Output: False
        Console.WriteLine(IsSumOfPowersOfDigits(9474)); // Output: True
    }
}

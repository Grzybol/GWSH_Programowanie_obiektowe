using System;

public class Program
{
    public static int NextSmaller(int number)
    {
        char[] digits = number.ToString().ToCharArray();
        int i = digits.Length - 2;
        

        while (i >= 0 && digits[i] <= digits[i + 1])
            i--;

        if (i == -1)
            return -1;

        int j = digits.Length - 1;
        while (digits[j] >= digits[i])
            j--;


        Swap(ref digits[i], ref digits[j]);


        Array.Reverse(digits, i + 1, digits.Length - i - 1);

        int result = int.Parse(new string(digits));
        if (result < number)
            return result;
        else
            return -1;
    }

    private static void Swap(ref char a, ref char b)
    {
        char temp = a;
        a = b;
        b = temp;
    }

    public static void Main()
    {
        Console.WriteLine(NextSmaller(21));  // Output: 12
        Console.WriteLine(NextSmaller(531)); // Output: 513
        Console.WriteLine(NextSmaller(2071));// Output: 2017
        Console.WriteLine(NextSmaller(9));   // Output: -1
        Console.WriteLine(NextSmaller(111)); // Output: -1
        Console.WriteLine(NextSmaller(135)); // Output: -1
        Console.WriteLine(NextSmaller(1027));// Output: -1
    }
}
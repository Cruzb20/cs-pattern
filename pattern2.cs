
using System;

public class Program
{
    public static void Main(string[] args)
    {
        PrintPattern("5*3*1*3*5");
    }

    public static void PrintPattern(string str)
    {
        int len = str.Length;

        // i goes from 0 to len and j goes from len-1 to 0
        for (int i = 0, j = len - 1; i <= len && j >= 0; i++, j--)
        {
            // To print the upper part. This loop runs
            // till the middle point of the string (i and j become the same)
            if (i < j)
            {
                // Print i spaces
                for (int x = 0; x < i; x++)
                    Console.Write(" ");

                // Print i-th character
                Console.Write(str[i]);

                // Print j-i-1 spaces
                for (int x = 0; x < j - i - 1; x++)
                    Console.Write(" ");

                // Print j-th character
                Console.WriteLine(str[j]);
            }

            // To print the center point
            if (i == j)
            {
                // Print i spaces
                for (int x = 0; x < i; x++)
                    Console.Write(" ");

                // Print middle character
                Console.WriteLine(str[i]);
            }

            // To print the lower part
            else if (i > j)
            {
                // Print j spaces
                for (int x = j - 1; x >= 0; x--)
                    Console.Write(" ");

                // Print j-th character
                Console.Write(str[j]);

                // Print i-j-1 spaces
                for (int x = 0; x < i - j - 1; x++)
                    Console.Write(" ");

                // Print i-th character
                Console.WriteLine(str[i]);
            }
        }
    }
}
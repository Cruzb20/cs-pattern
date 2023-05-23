using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = 5; // Maximum number of rows

        // Upper half of the pattern
        for (int i = 1; i <= n; i++)
        {
            // Print numbers in increasing order
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i * j + "\t");
            }

            Console.WriteLine();
        }

        // Lower half of the pattern
        for (int i = n - 1; i >= 1; i--)
        {
            // Print numbers in increasing order
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i * j + "\t");
            }

            Console.WriteLine();
        }
    }
}

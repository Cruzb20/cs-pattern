
                    Console.Write(" * ");
                }
                else
                {
                    Console.Write("  ");
                }
            }

            Console.WriteLine();
        }

        // Bottom Diamond Pattern
        for (int i = 4; i >= 1; i--)
        {
            for (int j = 5; j > i; j--)
            {
                Console.Write("  ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                if (k == 1 || k == (2 * i - 1))
                {
                    Console.Write(" * ");
                }
                else
                {
                    Console.Write("  ");
                }
            }

            Console.WriteLine();
        }
    }
}
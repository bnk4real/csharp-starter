class FooLoop
{
    public static void Forrloop()
    {
        // for loop is used when we know how many times we want to loop through
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Number of increment: " + i);
        }

        // nested loops
        // Outer loop
        for (int i = 1; i <= 2; ++i)
        {
            Console.WriteLine("Outer: " + i);  // Executes 2 times
            // Inner loop
            for (int j = 1; j <= 3; j++)
            {
                Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
            }
        }
        
    }
}
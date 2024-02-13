class WhileLoop
{
    public static void Whileloop()
    {
        // sample while
        int i = 0;
        while (i <= 10)
        {
            Console.WriteLine("Number of increment: " + i);
            i++;
        }

        // do-while
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i <= 10);
    }
}
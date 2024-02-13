class LogicalOpeator
{
    public static void Logicalopeator()
    {
        int x = 0;
        // and
        Console.WriteLine(x < 5 && x < 10);
        // or
        Console.WriteLine(x < 5 || x < 4);
        // not
        Console.WriteLine(!(x < 5 && x < 10));
    }
}
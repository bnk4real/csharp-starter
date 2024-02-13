class IfElse
{
    public static void Ifelse()
    {
        int x = 100, y = 200;

        if (x < y)
        {
            Console.WriteLine("x is lower y 100");
        }
        else
        {
            Console.WriteLine("x is greater y 100");
        }

        // else-if
        if (x < y)
        {
            Console.WriteLine("x is lower y 100");
        }
        else if (x > y)
        {
            Console.WriteLine("x is greater y 100");
        }

        // short-hand if-else
        // variable = (condition) ? expressionTrue :  expressionFalse;
        string result = (x > y) ? "x is lower y 100" : "x is greater y 100";
        Console.WriteLine("Result: " + result);
    }
}
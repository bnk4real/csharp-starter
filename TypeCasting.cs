class TypeCasting
{
    public static void Casting()
    {
        double myDouble = 9.78;
        int myInt = (int)myDouble;    // Manual casting: double to int

        Console.WriteLine(myDouble);  // Outputs 9.78
        Console.WriteLine(myInt);     // Outputs 9

        // Type Conversion Methods 
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
    }
}
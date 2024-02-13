
class ForEach
{
    public static void Forloop()
    {
        // loop through string elements
        string[] cars = { "Asus", "MSI", "MacBook", "Acer" };
        foreach (string i in cars)
        {
            Console.WriteLine("Elements in cars array: " + i);
        }

        // loop through integer elements
        int[] numbers = { 1, 4, 78, 123 };
        foreach (int n in numbers)
        {
            Console.WriteLine("Elements in numbers array: " + n);
        }

    }
}


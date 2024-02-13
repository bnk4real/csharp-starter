class ArrayList
{
    public static void Arraylist()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        cars[3] = cars[3].ToUpper();
        Console.WriteLine(cars[0]);
        // Now outputs MAZDA instead of Mazda

        // Sort an Array
        Array.Sort(cars);
        Console.WriteLine("Sorting Array: " + cars);
    }
}
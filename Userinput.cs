class UserInput
{
    public static void Userinput()
    {
        // input string
        Console.WriteLine("Enter name: ");
        string? userName = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (userName != "")
        {
            Console.WriteLine("Username is: " + userName);
            Console.WriteLine("Age is: " + age);
        }
        else if (userName == "")
        {
            Console.WriteLine("No name was entered.");
        }
    }
}

class Strings
{
    public static void StringS()
    {
        // length count
        string fullName = "Pawit Yodkaset";
        Console.WriteLine(fullName.Length);

        // upper and lower cases
        Console.WriteLine(fullName.ToUpper());
        Console.WriteLine(fullName.ToLower());

        // string concatenation 
        string firstName = "John ";
        string lastName = "Doe";
        string fullname = firstName + lastName;
        string name = string.Concat(firstName, lastName);
        Console.WriteLine("Normal concat " + fullname);
        Console.WriteLine("String.concat " + name);
    }
}
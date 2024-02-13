class Variables
{
    public static void Vars()
    {
        string fname = "Pawit";  // String
        int age = 30;            // int
        double doub = 29.8D;     // double
        float money = 12.50F;    // float
        decimal value = 13.5m;   // decimal
        char cha = 'a';          // only one character
        bool myBool = true;      // boolean

        // constants not be able to change
        const string Lname = "Yodkasset";

        // multiple values
        string a = "a", b = "b", c = "c";
        Console.Write(a + b + c);

        // print out
        Console.Write(fname + Lname);
        Console.Write(age);
        Console.Write(doub);
        Console.Write(myBool);
        Console.Write(money);
        Console.Write(value);
        Console.Write(cha);
    }
}
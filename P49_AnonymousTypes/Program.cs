using System;
class Program
{
    static void Main()
    {
        var anon = new { Name="Bob", Age=42 };
        Console.WriteLine(anon.Name + " is " + anon.Age);
    }
}

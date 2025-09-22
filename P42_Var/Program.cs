using System;
class Program
{
    static void Main()
    {
        var x = 10;
        var text = "hello";
        Console.WriteLine("x type: " + x.GetType().Name);
        Console.WriteLine("text type: " + text.GetType().Name);
    }
}

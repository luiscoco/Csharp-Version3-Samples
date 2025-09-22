using System;
static class StringExtensions
{
    public static int WordCount(this string s){ return s.Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries).Length; }
}
class Program
{
    static void Main()
    {
        string text="hello world from C#";
        Console.WriteLine("WordCount="+text.WordCount());
    }
}

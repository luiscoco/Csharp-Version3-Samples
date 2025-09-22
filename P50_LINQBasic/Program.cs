using System; using System.Linq; using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var nums=new List<int>{1,2,3,4,5};
        var squares=nums.Select(n=>n*n);
        foreach(int s in squares) Console.WriteLine(s);
    }
}

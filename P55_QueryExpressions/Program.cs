using System; using System.Linq; using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var nums=new List<int>{1,2,3,4,5,6};
        var evens = from n in nums where n%2==0 select n;
        foreach(int e in evens) Console.WriteLine("even:"+e);
    }
}

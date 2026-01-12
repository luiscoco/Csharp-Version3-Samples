using System; using System.Linq; using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var nums=new List<int>{1,2,3,4,5,6};
        var groups=from n in nums group n by n%2==0 into g select g;
        foreach(var g in groups)
        {
            Console.WriteLine("Group key="+g.Key);
            foreach(int v in g) Console.WriteLine("  "+v);
        }
    }
}

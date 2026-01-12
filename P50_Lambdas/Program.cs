using System; using System.Linq; using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Func<int,int,int> add = (a,b) => a+b;
        Console.WriteLine("3+4="+add(3,4));
        List<int> nums=new List<int>{1,2,3,4,5};
        var evens=nums.Where(n=>n%2==0);
        foreach(int e in evens) Console.WriteLine("even:"+e);
    }
}

using System; using System.Linq.Expressions;
class Program
{
    static void Main()
    {
        Expression<Func<int,int>> square = x => x*x;
        Console.WriteLine("Expression: " + square);
        Func<int,int> compiled=square.Compile();
        Console.WriteLine("Square(5)="+compiled(5));
    }
}

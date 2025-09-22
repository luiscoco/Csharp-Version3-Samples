using System; using System.Collections.Generic;
class Person { public string Name { get; set; } public int Age { get; set; } }
class Program
{
    static void Main()
    {
        var p = new Person { Name="Alice", Age=30 };
        var nums = new List<int> {1,2,3,4};
        Console.WriteLine(p.Name + " " + p.Age);
        Console.WriteLine(string.Join(",", nums));
    }
}

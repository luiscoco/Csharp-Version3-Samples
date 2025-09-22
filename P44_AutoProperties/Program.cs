using System;
class Car
{
    public string Make { get; set; }
    public int Year { get; set; }
}
class Program
{
    static void Main()
    {
        Car c = new Car{Make="Ford",Year=2020};
        Console.WriteLine(c.Make + " " + c.Year);
    }
}

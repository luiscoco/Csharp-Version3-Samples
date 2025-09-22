using System;
partial class Demo
{
    partial void OnChanged();
    public void Change(){ Console.WriteLine("Change() called"); OnChanged(); }
}
partial class Demo
{
    partial void OnChanged(){ Console.WriteLine("OnChanged() implemented"); }
}
class Program
{
    static void Main(){ Demo d=new Demo(); d.Change(); }
}

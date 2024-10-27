using System;
using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Input the percent:");
        decimal percent = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Input your salary:");
        int salary = Convert.ToInt32(Console.ReadLine());
        int tax = Convert.ToInt32(salary * percent);
        Console.WriteLine($"Your tax on salary is:{tax}");
    }
}
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter age ");
        int a = int.Parse(Console.ReadLine());
        if (a >= 12 && a <= 18)
        {
            Console.WriteLine("Teenager");
        }
        else if (a > 0 && a < 12)
        {
            Console.WriteLine("Kid");
        }
        else if (a > 18 && a < 100)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Death");
        }
    }
}
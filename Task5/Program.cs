using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number ");
        int c = int.Parse(Console.ReadLine());
        {
            if ((a > b) & (a > c))
            {
                Console.WriteLine("First number");
            }
            else if ((a < b) & (a > c))
            {
                Console.WriteLine("Second number");
            }
            else
            {
                Console.WriteLine("Third number");
            }
        }
    }
}
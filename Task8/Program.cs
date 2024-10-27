using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the side a ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the side b ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the side c ");
        int c = int.Parse(Console.ReadLine());
        {
            if ((a > b) & (a > c))
            {
                Console.WriteLine("a is the longest");
            }
            else if ((a < b) & (a > c))
            {
                Console.WriteLine("b is the longest");
            }
            else
            {
                Console.WriteLine("c is the longest");
            }
        }
    }
}
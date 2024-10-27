using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("ВВедіть число");
        int a = int.Parse(Console.ReadLine());
        if ((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0))
        {
            Console.WriteLine("Високосний");
        }
        else
        {
            Console.WriteLine("Не високосний");
        }
    }
}
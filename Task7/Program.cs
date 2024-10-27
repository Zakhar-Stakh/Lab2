using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Число є парним");
            }
            else
            {
                Console.WriteLine("Число є непарним");
            }

            if (number % 3 == 0)
            {
                Console.WriteLine("Число ділиться на 3");
            }
            else
            {
                Console.WriteLine("Число не ділиться на 3");
            }
        }
        else
        {
            Console.WriteLine("Введено некоректне значення");
        }
    }
}
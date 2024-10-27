class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть число");
        int a = int.Parse(Console.ReadLine());
        if (a > 0)
        {
            Console.WriteLine("Додатнє");
        }
        else if (a < 0)
        {
            Console.WriteLine("Від'ємне");
        }
        else
        {
            Console.WriteLine("Дорівнює нулю");
        }

    }
}
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string letter;
        Console.Write("Enter a loud letter:");
        letter = Convert.ToString(Console.ReadLine());
        if (letter == "A")
        {
            Console.WriteLine("It's a  loud letter");
        }
        if (letter == "E")
        {
            Console.WriteLine("It's a  loud letter");
        }
        if (letter == "I")
        {
            Console.WriteLine("It's a  loud letter");
        }
        if (letter == "O")
        {
            Console.WriteLine("It's a  loud letter");
        }
        if (letter == "U")
        {
            Console.WriteLine("It's a  loud letter");
        }
        else
        {
            Console.WriteLine("That`s probably not loud letter");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user_name = PromptUserName();
        int user_number = PromptUserNumber();
        int number_squared = SquareNumber(user_number);
        DisplayResult(user_name, number_squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("what is your favorite number?: ");
        string number_str = Console.ReadLine();
        int number = int.Parse(number_str);
        return number;
    }

    static int SquareNumber(int user_number)
    {
        int square = user_number * user_number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}
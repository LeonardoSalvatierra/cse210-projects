using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage?: ");
        string user_grade = Console.ReadLine();
        int grade = int.Parse(user_grade);

        string letter = "";

        if ( grade >= 90)
        {
            letter = "A";
        }
        else if ( grade >= 80)
        {
            letter = "B";
        }
        else if ( grade >= 70)
        {
            letter = "C";
        }
        else if ( grade >= 60)
        {
            letter = "D";
        }
        else if ( grade < 60)
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is '{letter}' ");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation! you passed!");
        }
        else
        {
            Console.WriteLine("you didn't pass, try harder next time!");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int number = randomgenerator.Next(1,100);
        string response = "no";
        int guesses = 1;
        do 
        {
            Console.Write("What is your guess?: ");
            string guess_input = Console.ReadLine();
            int guess_number = int.Parse(guess_input);

            if (guess_number == number)
            {
                Console.WriteLine("You guessed it!");
                response = "yes";
                Console.WriteLine($"you did {guesses} guesses.");
            }
            else if (guess_number > number)
            {
                Console.WriteLine("lower!");
            }
            else
            {
                Console.WriteLine("higher!");
            }
            guesses = guesses + 1;
        } while (response == "no");
        
    }
}
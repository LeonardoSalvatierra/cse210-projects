using System;

public class ReflectionActivity :Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    public List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectionActivity(string name, string description, int duration) : base(name, description)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Run()
    {
        Console.WriteLine("Consider the followin prompt: ");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine("When you have something in mind press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"{question}");
            ShowSpinner();
            Console.WriteLine("");
        }

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {
        
    }
}
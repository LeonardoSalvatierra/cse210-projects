using System;

public class ListingActivity : Activity
{
    private int _count;
    private string _prompt;
    private string _name;
    private string _description;
    private int _duration;
    public List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity(string name, string description, int duration) : base(name, description)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("List as many responses you can yo the following prompt:");
        GetRandomPrompt();
        Console.Write("Yoy may begin in: ");
        ShowCountDown();
        Console.WriteLine("");
        GetListFromUser();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine($"{randomPrompt}");
    }
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> userList = new List<string>();
        _count = 0;
        while(DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            userList.Add(input);
            _count++;
            
        }
        Console.WriteLine($"You listed {_count} Items!");
        return userList;
    }

}
using System;
using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public int DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!!\n\n");
        Thread.Sleep(1000);
        Console.WriteLine(_description);
        Thread.Sleep(1000);
        Console.Write("\nHow Long, in seconds, would you like for your session?: ");
        return int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage(int duration, string activity1)
    {
        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine($"You have completed another {duration} seconds of the {activity1}.");
        ShowSpinner();
        
    }
    public void ShowSpinner()
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(7);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animation.Count)
            {
                i = 0;
            }
        }


    }
    public void ShowCountDown()
    {
        for (int i = 5; i > 5; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
    }
}
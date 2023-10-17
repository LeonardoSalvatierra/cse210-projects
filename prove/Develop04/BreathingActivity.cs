using System;

public class BreathingActivity : Activity
{   
    private int _duration;
    public BreathingActivity(string name, string description, int duration) : base(name, description)
    {
        _duration = duration;
    }
    public void Run()
    {
        
        //int seconds = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"Breath in...");
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            for (int i = 0; i < 7; i++)
            {
                Console.Clear();
                Console.WriteLine($"Breath out...");
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            
        }

    }
}
using System;

public class Entry
{
    public string _prompt = "";
    public string _response = "";
    public string _date = "";

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} - prompt: {_prompt} - {_response}");
    }
}
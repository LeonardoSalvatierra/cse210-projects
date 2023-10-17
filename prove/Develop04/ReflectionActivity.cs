using System;

public class ReflectionActivity :Activity
{
    private string _name;
    private string _description;
    public List<string> _prompts = new List<string>();
    public List<string> _questions = new List<string>();

    public ReflectionActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
    }
    public void Run()
    {

    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {
        
    }
}
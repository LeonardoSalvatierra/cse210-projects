using System;

public class ListingActivity : Activity
{
    public int _count;
    private string _name;
    private string _description;
    public List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
    }
    public void Run()
    {

    }
    public void GetRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        return list;
    }

}
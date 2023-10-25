using System;
using System.Net;
using System.Reflection;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    public List<Comments> _comments;

    public Video( string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comments>();
    }
    public void AddComment(string author, string comment)
    {
        Comments newComment = new Comments(author, comment);
        _comments.Add(newComment);
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine("\n--- VIDEO INFO ---");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Lenght in seconds: {_lengthSeconds}");
        Console.WriteLine($"Lenght in HH:MM:SS: {GetLenghtInHHMMSS()}");
        Console.WriteLine($"Number of comments: {GetCommentsCount()}");
    }
    public void DisplayVideoComments()
    {
        Console.WriteLine("\n--- COMMENTS ---");
        foreach(Comments comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommentName()}\n {comment.GetCommentText()}");
        }
    }
    public string GetLenghtInHHMMSS()
    {
        TimeSpan time = TimeSpan.FromSeconds(_lengthSeconds);
        return time.ToString(@"hh\:mm\:ss");

    }
    
    //GETTERS
    public string GetAuthor()
    {
        return _author;
    }
    public string GetTitle()
    {
        return _title;
    }
    public int GetLenght()
    {
        return _lengthSeconds;
    }
    public int GetCommentsCount()
    {
        return _comments.Count();
    }
}
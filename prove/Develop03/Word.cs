using System;
using System.ComponentModel;

public class Word
{   
    private string _text;

    public Word(string text)
    {
        _text = text;
    }
    public string Hide()
    {
        return _text = "____";
    }
    public void Show()
    {
        
    }
    public bool IsHidden(string word)
    {
        if (word == "____")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
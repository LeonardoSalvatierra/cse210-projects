using System;

public class Scripture
{

    private List<string> _words = new List<string>();

    public Scripture(string words)
    {
        List<string> wordsList = new List<string>(words.Split(" "));
        _words.AddRange(wordsList);
    }
    public void HideRandomWords()
    {
        Random random = new Random();
        bool run = true;
        while (run)
        {
            int randomNum = random.Next(_words.Count);
            Word word = new Word(_words[randomNum]);
            if (word.IsHidden(_words[randomNum]) != true)
            {
                string hide = word.Hide();
                _words[randomNum] = hide;
                run = false;
            }
        }
    }
    public string GetDisplayText()
    {
        return string.Join(" ",_words);
    }
    public bool IsCompletelyHidden()
    {
        int count = 0;
        foreach (string word in _words)
        {
            if (word == "____")
            {
                count += 1;
            }
        }
        int verseLength = _words.Count();
        if (count == verseLength)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
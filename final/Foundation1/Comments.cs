using System;
using System.Net;
using System.Transactions;

public class Comments
{
    private string _commenterName;
    private string _commentText;

    public Comments(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }
    public string GetCommentText()
    {
        return _commentText;
    }
    public string GetCommentName()
    {
        return _commenterName;
    }
}
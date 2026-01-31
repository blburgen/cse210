public class Comment
{
    private string _commenter;
    private string _commentText;

    public Comment(string commenter, string commentText)
    {
        _commenter = commenter;
        _commentText = commentText;
    }

    public string GetCommentText()
    {
        return $"Commenter: {_commenter}, Text: {_commentText}";
    }
    public string GetCommenter()
    {
        return _commenter;
    }

    public string GetText()
    {
        return _commentText;
    }
}

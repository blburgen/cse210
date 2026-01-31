public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = [];

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public Video(string title, string author, int length, List<Comment> commentList)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = commentList;
    }

    public void AddComment(string commenter, string text)
    {
        Comment comment = new Comment(commenter, text);
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public string GetCommentsContent()
    {
        string temp = "";
        foreach(Comment item in _comments)
        {
            temp += $"{item.GetCommentText()}\n";
        }
        return temp;
    }

    public string GetVideoInfomation()
    {
        string temp = $"Title: {_title}\n";
        temp += $"Author: {_author}\n";
        temp += $"Length: {_length}seconds\n";
        temp += $"Number of Comments: {CountComments()}\n";
        temp += $"Comments:\n{GetCommentsContent()}";
        return temp;
    }

}
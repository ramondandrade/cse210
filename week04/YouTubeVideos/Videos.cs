// AUTHIR

class Videos
{

    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comments> _comments;

    public Videos(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comments>();
    }

    public void AddComment(Comments comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    // New: Display video
    public string DisplayVideo()
    {
        return $"{_title} - Author: {_author} / Comments: {CountComments()}";
    }

    public void ShowComments()
    {
        foreach (var comments in _comments)
        {
            comments.DisplayComment();
        }
    }


}

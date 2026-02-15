namespace YouTubeVideos;
class Video{
    private string _title;
    private string _author;
    private double _length;

    private List<Comment> comments = new List<Comment>();

    public Video(string title,string author,double length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void SetTitle(string title){
        _title = title;
    }
    public string GetTitle(){
        return _title;
    }
    public void SetAuthor(string author){
        _author = author;
    }
    public string GetAuthor(){
        return _author;
    }
    public void SetLength(double length){
        _length = length;
    }
    public double GetLength(){
        return _length;
    }

    public void AddComment(string author,string comment){
        comments.Add(new Comment(author,comment));
    }
    public List<Comment> GetComments(){
        return comments;
    }
}
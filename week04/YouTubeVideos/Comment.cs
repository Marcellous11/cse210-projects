using System.Reflection;

namespace YouTubeVideos;
class Comment{
    private string _author;
    private string _comment;

    public Comment(string author, string comment){
        _author = author;
        _comment = comment;
    }

    public void SetAuthor(string author){
        _author = author;
    }

    public string GetAuthor(){
        return _author;
    }

    public void SetComment(string comment){
        _comment = comment;
    }
    public string GetComment(){
        return _comment;
    }
}
using System;
namespace YouTubeVideos;
class Program
{
    static void Main(string[] args)
    {

        List<Video> allVideos = new List<Video>();

        Video failVideo = new Video("Best Failed 2026","FailArmy",23.5);
        failVideo.AddComment("Mikey","That was crazy");
        failVideo.AddComment("LoJo","Fav video of all time!!");
        failVideo.AddComment("steve","Was this AI geraeated?");
        Video MTVChoiceVideo = new Video("MTV Best Choice Award 2009","MTV",12.9);
        MTVChoiceVideo.AddComment("leeroy","Should have been 50 cent!");
        MTVChoiceVideo.AddComment("JJ","Where was Em?");
        MTVChoiceVideo.AddComment("BruceLee","I love Beyonce!!");
        Video spaceVideo = new Video("How Big is Space","Space Channel",30.2);
        spaceVideo.AddComment("Deepthoughts","Just wait till we get to marz!");
        spaceVideo.AddComment("flateearth","This is all lies spread by NASA");
        spaceVideo.AddComment("science","But would they survive a blackhole landing like Matthew McConaughey?");

        allVideos.Add(spaceVideo);
        allVideos.Add(failVideo);
        allVideos.Add(MTVChoiceVideo);

        allVideos.ForEach(video=>{
            Console.WriteLine($"Title: {video.GetAuthor()}");
            Console.WriteLine($"Author: {video.GetTitle()}");
            Console.WriteLine($"length: {video.GetLength()} mins");
            Console.WriteLine("Comments:");
            video.GetComments().ForEach(comment =>{
                Console.WriteLine($"\tAuthor: {comment.GetAuthor()}");
                Console.WriteLine($"\tComment: {comment.GetComment()}");
            });

        });


    }
}
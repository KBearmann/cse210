using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video video = new Video("Programming", "James Kt", "102 seconds");
        video.VideoInfo();
        video.AddComment("Bob", "AWesome");
        video.AddComment("Martha", "USeful");
        video.AddComment("Lisa", "BAD");
        video.Comments();
        Video video2 = new Video("Building Stuff", "Chris", "20 seconds");
        video2.VideoInfo();
        video2.AddComment("Ames", "Cool");
        video2.AddComment("greg", "i love building");
        video2.AddComment("hans", "building is awesome");
        video2.Comments();
        Video video3 = new Video("Vase Tutorial", "Yanes", "1568 seconds");
        video3.VideoInfo();
        video3.AddComment("Hannah", "gonna use this later");
        video3.AddComment("brock", "didnt' know you could do this");
        video3.AddComment("Kaitlin", "so pretty");
        video3.AddComment("Genifer", "original");
        video3.Comments();
    }
}

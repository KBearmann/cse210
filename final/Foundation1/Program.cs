using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video video = new Video("Progaming SODA", "Ally Kt", "1223 seconds");
        video.VideoInfo();
        video.AddComment("Cerrie", "Loved the video!");
        video.AddComment("Valerie", "Thank you this helped so much!");
        video.AddComment("Kevin", "Didn't help or solve my problem.");
        video.Comments();
        Video video2 = new Video("Kite Flying and You", "Kristie", "2023 seconds");
        video2.VideoInfo();
        video2.AddComment("Aries", "Been waiting on a kite viedo.");
        video2.AddComment("Kerin", "I think you attached that kite wrong.");
        video2.AddComment("Bryan", "Could you please do a Video about kite flying with fiends?");
        video2.Comments();
        Video video3 = new Video("Fly Tying Tutorial", "Flyfish Projects", "1568 seconds");
        video3.VideoInfo();
        video3.AddComment("Han", "going to spin some of these up!");
        video3.AddComment("Joe", "Loved your techinque");
        video3.AddComment("Katie", "so pretty");
        video3.AddComment("Rob P", "original");
        video3.Comments();
    }
}

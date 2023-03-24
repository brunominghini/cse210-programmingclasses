using System;

class Program
{
    static void Main(string[] args)
    {   string titleVideo;
        string authorVideo;
        int lengthVideo;
        string nameComment;
        string commentWrote;

        //Video video = new Video();
        List<Video> videosList = new List<Video>();

        Console.Write("Whats the title of video:");
        //video._title = Console.ReadLine();
        titleVideo = Console.ReadLine();

        Console.Write("Whats the author of video:");
        //video._author = Console.ReadLine();
        authorVideo = Console.ReadLine();

        Console.Write("Whats the length in second of video:");
        //video._length = Convert.ToInt16(Console.ReadLine());
        lengthVideo = Convert.ToInt16(Console.ReadLine());


        videosList.Add(new Video (titleVideo, 
                                 authorVideo, 
                                lengthVideo));
        /*videosList.Add(video._title);
        videosList.Add(video._author);
        videosList.Add(video._length);*/

        foreach (var item in videosList){
          Console.WriteLine ($"Title: {titleVideo}, Author: {authorVideo}, Length: {lengthVideo}");
          Console.WriteLine();      
        }



        Console.Write("Whats is your name:");
        nameComment =  Console.ReadLine();

        Console.Write("Write your comment:");
        commentWrote = Console.ReadLine();
          
        Comment comment1 = new Comment(nameComment, commentWrote);
        



    }
}
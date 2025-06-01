using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        //create first videos and comment
        Video video1 = new Video("Nature", "Jane Michael", 20);
        //Create 3 comments
        Comment comment1 = new Comment("Mark", "Great video!");
        Comment comment2 = new Comment("John", "Awesome.");
        Comment comment3 = new Comment("Lucy", "Lovely video!");
        video1.AddComments(comment1);
        video1.AddComments(comment2);
        video1.AddComments(comment3);
        

        //create second videos and comment
        Video video2 = new Video("The Blue Whale", "Nora Peter", 33);
        //Create 4 comments
        Comment comment4 = new Comment("Leonard", "Fantastic!");
        Comment comment5 = new Comment("Luke", "Interesting vidoe.");
        Comment comment6 = new Comment("Jerry", "I love It!");
        Comment comment7 = new Comment("Matthew", "Nice!");
        video2.AddComments(comment4);
        video2.AddComments(comment5);
        video2.AddComments(comment6);
        video2.AddComments(comment7);
        

        //create third videos and comment
        Video video3 = new Video("Holiday", "Smith Patrick", 27);
        //Create 3 comments
        Comment comment8 = new Comment("Joy", "Amazing!");
        Comment comment9 = new Comment("Adams", "What an exciting video.");
        Comment comment10 = new Comment("Noah", "Wow! beautiful.");
        video3.AddComments(comment8);
        video3.AddComments(comment9);
        video3.AddComments(comment10);
        
        //Create a list of videos and display the information
        List<Video> _youTubeVideos = new List<Video>();
        _youTubeVideos.Add(video1);
        _youTubeVideos.Add(video2);
        _youTubeVideos.Add(video3);
        foreach(Video video in _youTubeVideos)
        {
            video.DisplayVideoInfo();
        }

    }
}
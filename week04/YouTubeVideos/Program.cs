using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video list
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("The Rise of AI", "TechWorld", 320);
        video1.AddComment(new Comment("Sophia", "This video blew my mind!"));
        video1.AddComment(new Comment("Leo", "Amazing explanation."));
        video1.AddComment(new Comment("Amara", "I love how deep it went."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Nature's Secrets", "PlanetWild", 455);
        video2.AddComment(new Comment("Chris", "I feel like I was in the jungle!"));
        video2.AddComment(new Comment("Nina", "Loved the cinematography."));
        video2.AddComment(new Comment("Zane", "This is peaceful."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("C# in 10 Minutes", "CodeCamp", 600);
        video3.AddComment(new Comment("DevKing", "Straight to the point."));
        video3.AddComment(new Comment("Maya", "Very helpful, thanks!"));
        video3.AddComment(new Comment("Ahmed", "Awesome tutorial."));
        videos.Add(video3);

        // Display videos
        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine(); // Space between videos
        }
    }
}

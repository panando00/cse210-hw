using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // a list for storing videos
        List<Video> videos = new List<Video>();

        // videos and comments
        Video video1 = new Video("Learning C# in 10 Mins", "CodeMaster", 600);
        video1.AddComment("Prosper Zvidzai", "Great tutorial! Very clear explanation.");
        video1.AddComment("Prosper", "Could you make one about inheritance?");
        video1.AddComment("Elder Yong", "This helped me so much with my project!");
        videos.Add(video1);

        Video video2 = new Video("Piano Tutorial - Moonlight Sonata", "MusicTeacher", 900);
        video2.AddComment("Justin Bierber", "Beautiful interpretation!");
        video2.AddComment("Chris Brown", "The fingering explanation was very helpful");
        video2.AddComment("Chris Underson", "Can you do Für Elise next?");
        video2.AddComment("Killer T", "I've been struggling with this piece, thank you!");
        videos.Add(video2);

        Video video3 = new Video("Healthy Breakfast Ideas", "ChefCooking", 480);
        video3.AddComment("Chef Joe", "Made the smoothie bowl today - delicious!");
        video3.AddComment("Chef Lisa", "Great healthy options");
        video3.AddComment("Chef Amy", "Could you include calorie information next time?");
        videos.Add(video3);

        // showing infor for every video
        foreach (Video video in videos)
        {
            Console.WriteLine("\n=== Video Info ===");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            
            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine("================\n");
        }
    }
}
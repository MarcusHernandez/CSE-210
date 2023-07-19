using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        List<Video> videos = new List<Video>();

        // Create 3-4 videos and add comments for each one
        Video video1 = new Video("John Doe", "Introduction to Programming", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Eve", "I enjoyed it."));

        Video video2 = new Video("Jane Smith", "Data Structures and Algorithms", 400);
        video2.AddComment(new Comment("Carol", "Helped me a lot."));
        video2.AddComment(new Comment("Dave", "Could be more in-depth."));

        Video video3 = new Video("Mark Johnson", "Machine Learning Basics", 500);
        video3.AddComment(new Comment("Frank", "Fantastic explanation!"));

        // Add the videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information for each video
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine(); // Add a line break between videos
        }
    }
}

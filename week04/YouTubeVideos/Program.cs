using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create 3-4 videos and add them to the list
        Video video1 = new Video("How to Learn C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "I love this series."));
        video1.AddComment(new Comment("Charlie", "Very helpful, thanks!"));

        Video video2 = new Video("Understanding Abstraction", "Jane Smith", 450);
        video2.AddComment(new Comment("David", "I learned so much from this video."));
        video2.AddComment(new Comment("Eva", "Could you explain this concept further?"));
        video2.AddComment(new Comment("Frank", "This was a great introduction to abstraction."));

        Video video3 = new Video("C# Basics for Beginners", "James Bond", 600);
        video3.AddComment(new Comment("Grace", "This helped me understand the basics of C# better."));
        video3.AddComment(new Comment("Henry", "Looking forward to the next video in the series."));
        video3.AddComment(new Comment("Ivy", "Very clear explanations, thanks!"));

        // Add the videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos and display their information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // Add a blank line between videos for clarity
        }
    }
}

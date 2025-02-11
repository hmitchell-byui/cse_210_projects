using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create 3-4 videos
        Video video1 = new Video("Video Title 1", "Author 1", 300);
        Video video2 = new Video("Video Title 2", "Author 2", 450);
        Video video3 = new Video("Video Title 3", "Author 3", 600);

        // Add comments to each video
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Thanks for sharing."));
        video1.AddComment(new Comment("User3", "Very informative."));

        video2.AddComment(new Comment("User4", "I love this video!"));
        video2.AddComment(new Comment("User5", "Well done."));
        video2.AddComment(new Comment("User6", "Learned a lot from this."));

        video3.AddComment(new Comment("User7", "Amazing content!"));
        video3.AddComment(new Comment("User8", "Keep it up."));
        video3.AddComment(new Comment("User9", "This was very helpful."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }

            Console.WriteLine();
        }
    }
}

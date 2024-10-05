using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Funny Cat Video", "Cat Lover", 120),
            new Video("How to Make a Sandwich", "Cooking Channel", 60),
            new Video("Amazing Travel Destinations", "Travel Blogger", 300)
        };

        foreach (var video in videos)
        {
            video.AddComment(new Comment("Alice", "This video is hilarious!"));
            video.AddComment(new Comment("Bob", "I love cats!"));
            video.AddComment(new Comment("Charlie", "Great tutorial!"));
        }

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumComments()}");   

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment._user}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        
        Video video1 = new Video("Introduction to C#", "John Smith", 300);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "Thanks for the explanation.");
        video1.AddComment("User3", "Awesome video, thanks for the tips!");
        
        Video video2 = new Video("Top 10 Tourist Attractions in Paris", "Travel with Joe", 900);
        video2.AddComment("User4", "Delicious recipe, thanks for sharing!");
        video2.AddComment("User5", "Awesome video, thanks for the tips!");
        video2.AddComment("User6", "I'm planning my trip to Paris and this was really helpful.");

        Video video3 = new Video("React Tutorial for Beginners", "Programming with Sarah", 1200);
        video3.AddComment("User7", "Excellent tutorial, keep up the good work!");
        video3.AddComment("User8", "Can you also do a tutorial on Redux?");
        video3.AddComment("User9", "Can't wait to try this out.");

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (Video video in _videos) 
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());

        foreach (Comment comment in video.GetComments()) 
        {
            Console.WriteLine(comment.GetCommenter + ": " + comment.GetComment);
        }

            Console.WriteLine(); 
       }
    }
}
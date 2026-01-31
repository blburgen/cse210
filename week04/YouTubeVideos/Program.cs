using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> video1c = new List<Comment>();
        Comment c1 = new Comment("bob","This movie was great");
        video1c.Add(c1);
        Comment c2 = new Comment("Angila","This movie was great");
        video1c.Add(c2);
        Comment c3 = new Comment("Tim","Where did this come from");
        video1c.Add(c3);
        Comment c4 = new Comment("Rick","It was ok");
        video1c.Add(c4);
        Video video1 = new Video("Bill and Ted","The great one",60,video1c);
        videos.Add(video1);

        List<Comment> video2c = new List<Comment>();
        c1 = new Comment("bob","What the heck");
        video2c.Add(c1);
        c3 = new Comment("Tim","slept through it");
        video2c.Add(c3);
        c4 = new Comment("Rick","Ok Ok enought already");
        video2c.Add(c4);
        Video video2 = new Video("While I was sleeping","You Known",120,video2c);
        videos.Add(video2);

        List<Comment> video3c = new List<Comment>();
        c1 = new Comment("bob","Could not finnish it");
        video3c.Add(c1);
        c3 = new Comment("Tim","Too long");
        video3c.Add(c3);
        c2 = new Comment("Angila","You go girl");
        video3c.Add(c2);
        Video video3 = new Video("Look what happened","Unknown",3000,video3c);
        videos.Add(video3);

        foreach(Video video in videos)
        {
            Console.WriteLine(video.GetVideoInfomation());
            Console.WriteLine();
        }
        
    }
}
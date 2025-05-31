using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        Videos video = new Videos("How to Cook Pasta", "Chef Mario", 300);
        video.AddComment(new Comments("Jessica", "Great recipe!"));
        video.AddComment(new Comments("Katherine", "Looks delicious."));
        video.AddComment(new Comments("Julie", "Tried it, came out amazing!"));


        Videos video2 = new Videos("Hello world in C#", "Ramon Andrade", 300);
        video2.AddComment(new Comments("Ramon", "Great tutorial!"));
        video2.AddComment(new Comments("Marco", "Looks amazing to learn."));
        video2.AddComment(new Comments("Peter", "Nice! i'm learning C#"));


        Videos video3 = new Videos("Hello world in PHP", "Ramon Andrade", 300);
        video3.AddComment(new Comments("Juan", "Great tutorial, need to learn php!"));
        video3.AddComment(new Comments("Pepito", "Looks amazing to learn php"));
        video3.AddComment(new Comments("Fernando", "Best tutorial, thank you."));

        Console.WriteLine(video.DisplayVideo());
        video.ShowComments();

        Console.WriteLine("\n-------------------\n");

        Console.WriteLine(video2.DisplayVideo());
        video2.ShowComments();

        Console.WriteLine("\n-------------------\n");

        Console.WriteLine(video3.DisplayVideo());
        video3.ShowComments();

    }
}
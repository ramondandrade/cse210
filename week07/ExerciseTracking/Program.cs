using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("This is the ExerciseTracking Project.");
        ActivityHistory history = new ActivityHistory();

        // NEW: Created a Exercise manager
        ExerciseManager manager = new ExerciseManager(history);

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nAdd a new activity? (y/n)");
            string input = Console.ReadLine()?.Trim().ToLower();
            if (input == "y")
            {
                manager.AddActivityFromUserInput();
            }
            else
            {
                running = false;
            }
        }

        Console.WriteLine("\nAll recorded activities:");
        history.ShowAllSummaries();
        
    }
}

class ExerciseManager
{
    private ActivityHistory _history;

    public ExerciseManager(ActivityHistory history)
    {
        _history = history;
    }

    public void AddActivityFromUserInput()
    {
        
        Console.WriteLine("\n--- Exercise Manager ---");
        Console.WriteLine("Choose activity type:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Cycling");
        Console.WriteLine("3. Swimming");

        string type = Console.ReadLine()?.Trim().ToLower();

        Console.WriteLine("Enter date (yyyy-mm-dd), or leave blank for today:");
        string dateInput = Console.ReadLine();
        DateTime date = DateTime.Today;
        if (!string.IsNullOrEmpty(dateInput) && !DateTime.TryParse(dateInput, out date))
        {
            Console.WriteLine("Invalid date format. Using today's date.");
            date = DateTime.Today;
        }

        Console.WriteLine("Enter duration in minutes:");
        if (!double.TryParse(Console.ReadLine(), out double minutes) || minutes <= 0)
        {
            Console.WriteLine("Invalid duration. Aborting.");
            return;
        }

        switch (type)
        {
            case "1":
                Console.WriteLine("Enter distance in miles:");
                if (!double.TryParse(Console.ReadLine(), out double distance) || distance <= 0)
                {
                    Console.WriteLine("Invalid distance. Aborting.");
                    return;
                }
                _history.AddActivity(new Running(date, minutes, distance));
                break;

            case "2":
                Console.WriteLine("Enter speed in mph:");
                if (!double.TryParse(Console.ReadLine(), out double speed) || speed <= 0)
                {
                    Console.WriteLine("Invalid speed. Aborting.");
                    return;
                }
                _history.AddActivity(new Cycling(date, minutes, speed));
                break;

            case "3":
                Console.WriteLine("Enter number of laps:");
                if (!int.TryParse(Console.ReadLine(), out int laps) || laps <= 0)
                {
                    Console.WriteLine("Invalid number of laps.");
                    return;
                }
                _history.AddActivity(new Swimming(date, minutes, laps));
                break;

            default:
                Console.WriteLine("Unknown activity type.");
                break;
        }
    }
}
using System;

// Author: Ramon Andrade

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is you Journal.");


        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display all");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.Write($"{prompt} ");
                    string anwser = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    Entry newEntry = new Entry(date, prompt, anwser);
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":

                    if (journal._fileName != null)
                    {
                        Console.WriteLine($"Do you want to save in '{journal._fileName}' file? (y/n)");
                        string saveChoice = Console.ReadLine();
                        if (saveChoice.ToLower() == "y")
                        {
                            journal.SaveToFile(journal._fileName);
                            break;
                        }
                    }

                    Console.Write("Enter filename to save the journal: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case "4":

                    Console.Write("Enter filename to load the journal: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "5":

                    if (journal.CheckBeforeExit())
                    {
                        Console.WriteLine("Exiting the program.");
                        running = false;
                    }
                    else
                    {
                        running = true;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
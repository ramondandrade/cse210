using System;

class Program
{
    static void Main(string[] args)
    {

        // Start the program
        Reference reference = new Reference("1 Nephi", 3, 6, 7);
        Scripture scripture = new Scripture(reference, "Therefore go, my son, and thou shalt be favored of the Lord, because thou hast not murmured. And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        while (!scripture.IsCompletelyHidden())
        {   

            Console.Clear();

            // Show script with hidden words
            Console.WriteLine(scripture.GetDisplayText());

            // New option 'show', to start again.
            Console.WriteLine("\n\nPress 'enter' to hidden the words, 'show' to show all words or 'quit' to exit");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "quit")
            {
                break;
            }
            else if (answer.ToLower() == "show")
            {
                scripture.ShowAllWords(); 
            }
            else
            {
                scripture.HideRandomWords(3);
            }

        }

    }
}
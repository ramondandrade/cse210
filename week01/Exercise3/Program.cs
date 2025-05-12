using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random rnd = new Random();
        int number = rnd.Next(100);
        int actualGuess = -1;

        while (actualGuess != number)
        {
            Console.Write("What's your guess? ");
            actualGuess = int.Parse(Console.ReadLine());

            if (number > actualGuess){
                Console.WriteLine("No, higher");
            } else if (number < actualGuess){
                Console.WriteLine("No, lower");
            } else {
                Console.WriteLine("You correctly guessed the number!");
            }

        }  

    }
}
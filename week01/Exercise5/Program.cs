using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        
        // initial message
        DisplayWelcome();

        string userName = PromptUserName(); // Prompt user for their name
        int userNumber = PromptUserNumber(); // Prompt user for their favorite number
        int squaredNumber = SquareNumber(userNumber); // calculate the square of the number
       
        DisplayResult(userName, squaredNumber); // Display the result

    }

    static void DisplayWelcome(){
        Console.WriteLine("Hello, welcome!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number){
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}
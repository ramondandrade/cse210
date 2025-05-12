using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string gradeLetter = "";

        if (percent >= 90){
            gradeLetter = "A";
        }else if (percent >= 80){
            gradeLetter = "B";
        }else if (percent >= 70){
            gradeLetter = "C";
        }else if (percent >= 60){
            gradeLetter = "D";
        }else if (percent > 0 && percent < 60){
            gradeLetter = "F";
        }else{
            Console.WriteLine("Invalid grade percentage.");
            return;
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");
        
        if (percent >= 70){
            Console.WriteLine("Congrats! You passed!");
        } else {
            Console.WriteLine("You have to study more!");
        }

    }
}
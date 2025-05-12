using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbersList = new List<int>();
        int total = 0;
        int number = -1;

        while (number != 0){

            Console.Write("Enter a number (0 to quit): ");
            
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            
            if (number != 0)
            {
                numbersList.Add(number);
            }
        }


        foreach (int n in numbersList){
            total += n;
        }

        Console.WriteLine($"Sum: {total}");

        float average = total / numbersList.Count;
        
        Console.WriteLine($"Average: {average}");

        int max = numbersList[0];

        foreach (int n in numbersList){
            if (n > max){
                max = n;
            }
        }

        Console.WriteLine($"Max: {max}");

    }
}
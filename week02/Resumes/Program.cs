using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // First job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "TechCorp";
        job1._startYear = 2020;
        job1._endYear = 2023;
        //Console.WriteLine($"Company of job1: {job1._company}");
        //job1.Display();

        // Second job instance
        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "DataSolutions";
        job2._startYear = 2018;
        job2._endYear = 2021;
         //Console.WriteLine($"Company of job2: {job2._company}");
        //job2.Display();

        // Create a new instance of the Resume class
        Resume myResume = new Resume();

        // Set name
        myResume._name = "Ramon Andrade";

        // Add the two jobs to the list of jobs in the resume object
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Verify that you can access and display the first job title
        //Console.WriteLine($"First job title: {myResume._jobs[0]._jobTitle}");

        myResume.Display();

    }


}
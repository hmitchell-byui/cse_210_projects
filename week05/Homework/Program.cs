using System;

class Program
{
    static void Main(string[] args)
    {
        // First student : input
        Assignment assignment1 = new Assignment();
        assignment1.SetName("Samuel Bennet");
        assignment1.SetTopic("Multiplication");
        // Display Information
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        //Second student : input
        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetName("Roberto Rodriquez");
        assignment2.SetTopic("Fraction");
        assignment2.SetSection("2.3");
        assignment2.SetProblems("3-18");
        //Display Information
        Console.WriteLine(assignment2.GetSummary() +"\n"+ assignment2.GetHomeworkList());
        Console.WriteLine();

        //Third student : input
        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetName("Mary Walters");
        assignment3.SetTopic("European History");
        assignment3.SetWritingInformation("The Causes of World War II");
        //Display Information
        Console.WriteLine(assignment3.GetSummary() + "\n" + assignment3.GetWritingInformation());
        Console.WriteLine();
    }
}
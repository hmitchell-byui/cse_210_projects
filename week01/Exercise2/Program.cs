using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your number grade?");
        string answer =  Console.ReadLine();
        int grade = int.Parse(answer);
        string letter_grade;

        if (grade >= 90)
        {letter_grade = "A";}
        else if (grade >=80)
        {letter_grade = "B";}
        else if (grade >= 70)
        {letter_grade = "C";}
        else if (grade >= 60)
        {letter_grade = "D";}
        else
        {letter_grade = "F";}
        Console.WriteLine($"With a {grade}, your letter grade is {letter_grade}.");
    }
}
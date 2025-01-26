using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {   
        // Console.WriteLine("What is your magic number?");
        // string magic_number = Console.ReadLine();
        Random randomeGenerator = new Random();
        int magic_number = randomeGenerator.Next(1,101);
        int answer = 0;

        while (answer != magic_number)
        {
        Console.Write("Guess the Magic number.");
        answer = int.Parse(Console.ReadLine());
        Console.WriteLine($"You guessed {answer}.");
        if (magic_number > answer)
        {Console.WriteLine("Higher");}
        else if (magic_number < answer)
        {Console.WriteLine("Lower");}
        else
        {Console.WriteLine($"Congratulations! {magic_number} is the magic number.");}

        }
        
    }
}
using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    
    {   //This is where variable will go
        List<int> numbers = new List<int>();
        int number = -1;
        {Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
        number = int.Parse(Console.ReadLine());
        Console.WriteLine($"You entered {number}.");
        if(number != 0)
        {numbers.Add(number);}
        }
        int sum = 0;
        foreach (int value in numbers)
        {sum += value;}
        Console.WriteLine($"The sum of the values is {sum}.");

        float avg = ((float)sum / numbers.Count);
        Console.WriteLine($"The average of the values is {avg}.");

        int max = numbers[0];
        foreach (int value in numbers)
        {if( value > max)
        {max = value;}}
        Console.WriteLine($"The highest value is {max}.");

        }
    }
}
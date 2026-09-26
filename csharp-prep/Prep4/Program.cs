using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;

        Console.WriteLine("Ener a list of numbers, type 0 when finished.");
        
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            numbers.Add(number);
        }
        
        int Count = numbers.Count;
        int sum = 0;
        int max = numbers[0];
        
        foreach (int entry in numbers)
        {
            sum = sum + entry;
        }  
        int div = Count - 1;
        int avg = sum / div;

        foreach (int entry in numbers)
        {
            if (entry > max)
            {
                max = entry;
            }
        }   
 

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {avg}");
        Console.WriteLine($"The largest number is {max}");
    }
}
using System;
using System.Collections.Concurrent;



class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int correct = 1;
        Console.WriteLine("You have been randomly given a magic number between...");
        Console.WriteLine("Guess the number to win!");
        //Console.WriteLine($"the number is {number}");
        while (correct > 0)
        {
            Console.Write("What is your guess? ");
          string userInput = Console.ReadLine();
          int guess = int.Parse(userInput);
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            { 
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                correct = 0;
            }
            else
            {
                Console.WriteLine("Error");
                
            }

        }

    }
}
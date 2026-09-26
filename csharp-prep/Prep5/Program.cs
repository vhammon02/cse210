using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();
        
        int numberSquared = SquareNumber(userNumber);

        int userBirthYear;
        PromptUserBirthYear(out userBirthYear);

        DisplayResult(userName, numberSquared, userBirthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);

        return userNumber;
    }
    static void PromptUserBirthYear(out int userBirthYear)
    {
        Console.Write("Please enter the year you were born: ");

        string userInput = Console.ReadLine();
        userBirthYear = int.Parse(userInput);
    }
    static int SquareNumber(int userNumber)
    {
        int numberSquared = userNumber * userNumber;

        return numberSquared;

    }

    static void DisplayResult(string userName, int numberSquared, int userBirthYear)
    {
        int currentYear = DateTime.Now.Year;
        int userAge = currentYear - userBirthYear;

        Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
        Console.WriteLine($"{userName}, you will turn {userAge} this year");


    }
}
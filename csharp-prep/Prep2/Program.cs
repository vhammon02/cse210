using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("Please enter your grade as a percentage (eg. 95): ");
        string userInput = Console.ReadLine();

        int grade = int.Parse(userInput);
        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;
        int F = 60;
        string letter = "?";
        bool passed = false;

        int remainder = grade % 10;

        if (grade < F)
        {
            letter = "F";
            passed = false;
        }
        else if (grade < C)
        {
            letter = "D";
            passed = false;
        }
        else if (grade < B)
        {
            letter = "C";
            passed = true;
        }
        else if (grade < A)
        {
            letter = "B";
            passed = true;
        }
        else if (grade >= A)
        {
            letter = "A";
            passed = true;
        }
        else
        {
            Console.WriteLine("Grade is invalid");
        }


        if (remainder < 3 && letter != "F")
        {
            letter += "-";
        }
        else if (remainder >= 7 && letter != "F" && letter != "A")
        {
            letter += "+";
        }
        else
        {
            //No Change
        }

        if (letter == "A" || letter == "F")
        {
            Console.WriteLine($"You got an {letter}!");
        }
        else
        {
            Console.WriteLine($"You got a {letter}");
        }

        if (passed == true)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the course :(");
        }


    }
}
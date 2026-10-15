using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction wholeFraction = new Fraction();
        Fraction fiveFraction = new Fraction(5);
        Fraction threeFourths = new Fraction(3, 4);
        Fraction oneThird = new Fraction(1, 3);

        Console.WriteLine(wholeFraction.GetFractionString());
        Console.WriteLine(wholeFraction.GetDecimalValue());
        Console.WriteLine(fiveFraction.GetFractionString());
        Console.WriteLine(fiveFraction.GetDecimalValue());
        Console.WriteLine(threeFourths.GetFractionString());
        Console.WriteLine(threeFourths.GetDecimalValue());
        Console.WriteLine(oneThird.GetFractionString());
        Console.WriteLine(oneThird.GetDecimalValue());

        threeFourths.SetTop(2);
        threeFourths.SetBottom(5);
        Console.WriteLine($"Top: {threeFourths.GetTop()}");
        Console.WriteLine($"Bottom: {threeFourths.GetBottom()}");

        Random random = new Random();
        Fraction randomFraction = new Fraction();

        for (int i = 0; i < 20; i++)
        {
            randomFraction.SetTop(random.Next(1, 11));
            randomFraction.SetBottom(random.Next(1, 11));

            Console.WriteLine(randomFraction.GetFractionString());
            Console.WriteLine(randomFraction.GetDecimalValue());
        }
    }
}

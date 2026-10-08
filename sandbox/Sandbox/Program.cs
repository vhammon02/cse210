using System;

class Program
{
    static void Main(string[] args)
    {
        int arg = 7;
        int result = f(ref arg);
        Console.WriteLine($"arg contains {arg}");
        Console.WriteLine($"result contains {result}");
    }

    static int f(ref int argument_holder)
    {
        argument_holder += 2;
        return argument_holder + 1;
    }
}